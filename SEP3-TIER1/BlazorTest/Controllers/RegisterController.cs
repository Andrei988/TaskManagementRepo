using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class RegisterController : Controller
    {
        public async Task<string> Register(AsyncClient Client, string FirstName, string LastName, string Username,
            string Password, string SecondPassword, string Gender)
        {
            Message m = new Message
            {
                Resource = "user",
                Method = "register",
                Fields = new Fields
                {
                    User = new User
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Username = Username,
                        Gender = Gender
                    },
                    Password = Password
                }
            };

            if (SecondPassword == Password)
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(m));
            }

            return "Password did not match";
        }
    }
}