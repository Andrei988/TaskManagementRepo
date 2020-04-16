using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class NotificationsController : Controller
    {
        public async Task<string> GetNotifications(AsyncClient AsyncClient, string Username)
        {
            return await AsyncClient.SendAsync(JsonConvert.SerializeObject(new Message
            {
                Method = "getpendinginvitations",
                Resource = "project",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = Username
                    }
                }
            }));
        }

        public async Task<string> AcceptInvitation(AsyncClient AsyncClient, string Username, int ProjectId)
        {
            Message message = new Message
            {
                Method = "inviteaccept",
                Resource = "project",
                Fields = new Fields
                {
                    PendingInvitation = new PendingInvitation
                    {
                        Username = Username,
                        ProjectId = ProjectId
                    }
                }
            };

            return await AsyncClient.SendAsync(JsonConvert.SerializeObject(message));
        }

        public async Task<string> DeclineInvitation(AsyncClient AsyncClient, string Username, int ProjectId)
        {
            Message message = new Message
            {
                Method = "invitedecline",
                Resource = "project",
                Fields = new Fields
                {
                    PendingInvitation = new PendingInvitation
                    {
                        Username = Username,
                        ProjectId = ProjectId
                    }
                }
            };

            return await AsyncClient.SendAsync(JsonConvert.SerializeObject(message));
        }
    }
}