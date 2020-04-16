using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorTest.Model;
using BlazorTest.Networking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorTest.Controllers
{
    public class TasksController : Controller
    {
        public async Task<string> GetAllTasks(AsyncClient AsyncClient, int projectId)
        {
            try
            {
                return await AsyncClient.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "projecttasks",
                    Resource = "task",
                    Fields = new Fields
                    {
                        Projects = new List<Project>
                        {
                            new Project
                            {
                                Id = projectId
                            }
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> CreateTask(AsyncClient Client, Model.Task task)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "create",
                    Resource = "task",
                    Fields = new Fields
                    {
                        Tasks = new List<Model.Task>
                        {
                            task
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> DeleteTask(AsyncClient Client, Model.Task task)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "delete",
                    Resource = "task",
                    Fields = new Fields
                    {
                        Tasks = new List<Model.Task>
                        {
                            task
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // SubTasks

        public async Task<string> CreateSubTask(AsyncClient Client, SubTask subtask)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "create",
                    Resource = "subtask",
                    Fields = new Fields
                    {
                        SubTasks = new List<SubTask>
                        {
                            subtask
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> DeleteSubTask(AsyncClient Client, SubTask subtask)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "delete",
                    Resource = "subtask",
                    Fields = new Fields
                    {
                        SubTasks = new List<SubTask>
                        {
                            subtask
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> SetSubTaskComplete(AsyncClient Client, SubTask subtask)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "setcomplete",
                    Resource = "subtask",
                    Fields = new Fields
                    {
                        SubTasks = new List<SubTask>
                        {
                            subtask
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> GetSubTasks(AsyncClient Client, int taskId)
        {
            try
            {
                return await Client.SendAsync(JsonConvert.SerializeObject(new Message
                {
                    Method = "getsubtasks",
                    Resource = "subtask",
                    Fields = new Fields
                    {
                        SubTasks = new List<SubTask>
                        {
                            new SubTask
                            {
                                Id = taskId
                            }
                        }
                    }
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> SendComment(AsyncClient Client, TaskComment comm)
        {
            try
            {
                Message m = new Message
                {
                    Resource = "comment",
                    Method = "create",
                    Fields = new Fields
                    {
                        Comments = new List<TaskComment>
                        {
                            comm
                        }
                    }
                };

                return await Client.SendAsync(JsonConvert.SerializeObject(m));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}