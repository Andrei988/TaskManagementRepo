using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Entities;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Models.Handlers
{
    public class UserHandler : IUserHandler
    {
        private readonly Context Context;

        public UserHandler(Context Context)
        {
            this.Context = Context;
        }

        public string RegisterUser(Message message)
        {
            IUser user = Context.Users.Find(message.Fields.User.Username);

            try
            {
                var pass = message.Fields.Password;
                var rng = new RNGCryptoServiceProvider();
                var salt = GenerateSalt(rng, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(pass, Encoding.ASCII.GetBytes(salt), 10000);
                byte[] firstHash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];

                Array.Copy(Encoding.ASCII.GetBytes(salt), 0, hashBytes, 0, 16);
                Array.Copy(firstHash, 0, hashBytes, 16, 20);

                string hash = Convert.ToBase64String(hashBytes);

                var u = new User
                {
                    Username = message.Fields.User.Username,
                    FirstName = message.Fields.User.FirstName,
                    LastName = message.Fields.User.LastName,
                    Gender = message.Fields.User.Gender,
                    Salt = salt,
                    Hash = hash
                };

                if (user == null)
                {
                    Context.Add(u);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message(message.Resource, message.Method, 201,
                        "User created"));
                }

                return JsonConvert.SerializeObject(new Message(message.Resource, message.Method, 500,
                    "User exists"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message(message.Resource, message.Method, 500, e.Message));
            }
        }

        public string ChangePassword(Message Message)
        {
            try
            {
                IUser user = Message.Fields.User;

                var dbEntry = (from x in Context.Users
                    where x.Username == user.Username
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    var rcvPass = Message.Fields.Password;
                    var salt = dbEntry.Salt;

                    var pbkdf2 = new Rfc2898DeriveBytes(rcvPass, Encoding.ASCII.GetBytes(salt), 10000);
                    byte[] firstHash = pbkdf2.GetBytes(20);
                    byte[] hashBytes = new byte[36];

                    Array.Copy(Encoding.ASCII.GetBytes(salt), 0, hashBytes, 0, 16);
                    Array.Copy(firstHash, 0, hashBytes, 16, 20);

                    string hash = Convert.ToBase64String(hashBytes);

                    dbEntry.Hash = hash;

                    Context.Users.Update(dbEntry);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("user", "changepassword", 200, "User password updated"));
                }


                return JsonConvert.SerializeObject(new Message("user", "changepassword", 404, "User not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("user", "changepassword", 500, e.Message));
            }
        }

        public string Login(Message message)
        {
            try
            {
                IUser user = Context.Users.FirstOrDefault(user => user.Username == message.Fields.User.Username);

                var pass = message.Fields.Password;

                var salt = user.Salt;

                var pbkdf2 = new Rfc2898DeriveBytes(pass, Encoding.ASCII.GetBytes(salt), 10000);
                byte[] firstHash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];

                Array.Copy(Encoding.ASCII.GetBytes(salt), 0, hashBytes, 0, 16);
                Array.Copy(firstHash, 0, hashBytes, 16, 20);

                string hash = Convert.ToBase64String(hashBytes);

                if (hash == user.Hash)
                {
                    return JsonConvert.SerializeObject(new Message("user", "login", 200, "true"));
                }

                return JsonConvert.SerializeObject(new Message("user", "login", 200, "false"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message(message.Resource, message.Method, 500, e.Message));
            }
        }

        public string GetInfo(string Username)
        {
            try
            {
                IUser databaseEntry = Context.Users.FirstOrDefault(u => u.Username == Username);


                if (databaseEntry == null)
                {
                    return JsonConvert.SerializeObject(new Message("User", "getinfo", 404, "Resource not found"));
                }

                Message response = new Message
                {
                    Resource = "User",
                    Method = "getinfo",
                    Fields = new Fields
                    {
                        User = new User
                        {
                            FirstName = databaseEntry.FirstName,
                            LastName = databaseEntry.LastName,
                            Username = databaseEntry.Username,
                            Gender = databaseEntry.Gender
                        },
                        ResponseCode = 200,
                        ResponseDescription = "User info returned"
                    }
                };

                return JsonConvert.SerializeObject(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("User", "getinfo", 500, e.Message));
            }
        }


        public string GenerateSalt(RNGCryptoServiceProvider rng, int size)
        {
            var bytes = new Byte[size];
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

    }
}
