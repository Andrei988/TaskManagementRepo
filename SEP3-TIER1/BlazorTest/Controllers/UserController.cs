using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class UserController : Controller
    {
        public Task<string> GetInfo(AsyncClient client, string username)
        {
            Message m = new Message
            {
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = username
                    }
                },
                Method = "getinfo",
                Resource = "user"
            };

            string jsonMessage = JsonConvert.SerializeObject(m);


            return client.SendAsync(jsonMessage);
        }

        public Task<string> ChangePassword(AsyncClient client, string Username, string Password)
        {
            Message m = new Message
            {
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = Username,
                    },
                    Password = Password
                },

                Method = "changepassword",
                Resource = "user"
            };

            string jsonMessage = JsonConvert.SerializeObject(m);


            return client.SendAsync(jsonMessage);
        }
    }
}