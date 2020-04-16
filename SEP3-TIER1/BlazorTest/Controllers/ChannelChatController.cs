using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class ChannelChatController : Controller
    {
        public async Task<string> SendMessage(AsyncClient Client, int channelId, string username, string content)
        {
            Message m = new Message
            {
                Resource = "channel",
                Method = "sendmessage",
                Fields = new Fields
                {
                    ChannelMessages = new List<CMessage>
                    {
                        new CMessage
                        {
                            Sender = username,
                            ChannelId = channelId,
                            Content = content
                        }
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }

        public async Task<string> InitChat(AsyncClient Client, int channelId)
        {
            Message m = new Message
            {
                Method = "initchat",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            Id = channelId
                        }
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }

        public async Task<string> AddToChannel(AsyncClient Client, int channelId, string username)
        {
            Message m = new Message
            {
                Method = "adduser",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            Id = channelId
                        }
                    },
                    User = new User
                    {
                        Username = username
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }

        public async Task<string> DeleteFromChannel(AsyncClient Client, int channelId, string username)
        {
            Message m = new Message
            {
                Method = "deleteuser",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            Id = channelId
                        }
                    },
                    User = new User
                    {
                        Username = username
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }
    }
}