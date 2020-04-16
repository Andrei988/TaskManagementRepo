using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlazorTest.Networking;
using BlazorTest.Model;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class LoginController : Controller

    {
        public async Task<string> onSignIn(AsyncClient AsyncClient, string Username, string Password)
        {
            Message m = new Message
            {
                Method = "login",
                Resource = "user",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = Username
                    },
                    Password = Password
                }
            };

            return await AsyncClient.SendAsync(JsonConvert.SerializeObject(m));
        }
    }
}