using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace BlazorTest.Controllers
{
    public class ProjectController : Controller
    {
        public async Task<string> CreateProject(AsyncClient client, string Username, string ProjectName,
            string ProjectDescription)
        {
            Message message = new Message
            {
                Method = "create",
                Resource = "project",
                Fields = new Fields
                {
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Title = ProjectName,
                            Description = ProjectDescription,
                            OwnerUsername = Username
                        }
                    }
                }
            };
            return await client.SendAsync(JsonConvert.SerializeObject(message));
        }

        public async Task<string> GetProjectUsers(AsyncClient Client, int id)
        {
            var message = new Message
            {
                Resource = "project",
                Method = "getprojectusers",
                Fields = new Fields
                {
                    Projects = new List<Model.Project>
                    {
                        new Project
                        {
                            Id = id
                        }
                    }
                }
            };

            return await Client.SendAsync(JsonConvert.SerializeObject(message));
        }

        public async Task<string> GetProjectInfo(AsyncClient Client, int id)
        {
            try
            {
                var Message = new Message
                {
                    Resource = "project",
                    Method = "getinfo",
                    Fields = new Fields
                    {
                        Projects = new List<Model.Project>
                        {
                            new Project
                            {
                                Id = id
                            }
                        }
                    }
                };


                return await Client.SendAsync(JsonConvert.SerializeObject(Message));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> InviteUser(AsyncClient Client, string username, int projectId)
        {
            try
            {
                Message message = new Message
                {
                    Method = "invite",
                    Resource = "project",
                    Fields = new Fields
                    {
                        PendingInvitation = new PendingInvitation
                        {
                            ProjectId = projectId,
                            Username = username
                        }
                    }
                };

                string test = JsonConvert.SerializeObject(message);

                return await Client.SendAsync(JsonConvert.SerializeObject(message));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> KickUser(AsyncClient AsyncClient, string KickUsername, int projectId)
        {
            try
            {
                Message message = new Message
                {
                    Method = "deleteuser",
                    Resource = "project",
                    Fields = new Fields
                    {
                        User = new User
                        {
                            Username = KickUsername
                        },

                        Projects = new List<Project>
                        {
                            new Project
                            {
                                Id = projectId
                            }
                        }
                    }
                };

                return await AsyncClient.SendAsync(JsonConvert.SerializeObject(message));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}