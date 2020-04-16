using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class ChannelsController : Controller
    {
        public async Task<string> GetProjectChannels(AsyncClient Client, int id)
        {
            Message m = new Message
            {
                Method = "getchannels",
                Resource = "channel",
                Fields = new Fields
                {
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Id = id
                        }
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }

        public async Task<string> CreateChannel(AsyncClient Client, string Title, int projectId)
        {
            Message m = new Message
            {
                Method = "create",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            Title = Title,
                            ProjectId = projectId
                        }
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(m));
        }

        public async Task<string> AddUser(AsyncClient Client, int channelId, string username)
        {
            Message m = new Message
            {
                Method = "adduser",
                Resource = "channel",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = username
                    },
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

        public async Task<string> DeleteUser(AsyncClient Client, int channelId, string username)
        {
            Message m = new Message
            {
                Method = "deleteuser",
                Resource = "channel",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = username
                    },
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

        public async Task<string> DeleteChannel(AsyncClient Client, int channelId)
        {
            Message m = new Message
            {
                Method = "delete",
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
    }
}