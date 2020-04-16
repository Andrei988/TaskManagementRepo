using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Entities;
using Tier3Slit.Models.Handlers;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Models
{
    public class DatabaseInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>());

            context.Database.EnsureCreated();

            if (context.Users.Any() && context.Projects.Any() && context.Channels.Any() && context.ChannelUser.Any() &&
                context.ProjectChannels.Any()
                && context.TaskComment.Any() && context.Tasks.Any() && context.ChannelMessages.Any() &&
                context.ProjectUser.Any() && context.UserTask.Any())
            {
                return;
            }

            IUserHandler userHandler = new UserHandler(context);
            IProjectHandler projectHandler = new ProjectHandler(context);
            ITaskHandler taskHandler = new TaskHandler(context);
            IChannelHandler channelHandler = new ChannelHandler(context);

//            CreateUsers(userHandler);
//            CreateProjects(projectHandler);
//            CreatePendingInvitations(projectHandler);
//            CreateRandomTasks(taskHandler);
//            CreateChannels(channelHandler);
//            AddUsersToChannels(channelHandler);
//            CreateMessages(channelHandler);
//            CreateSubTasks(taskHandler);
//            CreateComments(taskHandler);
        }

        public static void CreateComments(TaskHandler taskHandler)
        {
            taskHandler.AddComment(new Message
            {
                Resource = "comment",
                Method = "add",
                Fields = new Fields
                {
                    Comments = new List<TaskComment>
                    {
                        new TaskComment
                        {
                            TaskId = 1,
                            Date = DateTime.Now,
                            Username = "Lukas28",
                            Comment = "This is a comment!"
                        }
                    }
                }
            });

            taskHandler.AddComment(new Message
            {
                Resource = "comment",
                Method = "add",
                Fields = new Fields
                {
                    Comments = new List<TaskComment>
                    {
                        new TaskComment
                        {
                            TaskId = 1,
                            Date = DateTime.Now,
                            Username = "Lukas28",
                            Comment = "This is a comment!!!!"
                        }
                    }
                }
            });

            taskHandler.AddComment(new Message
            {
                Resource = "comment",
                Method = "add",
                Fields = new Fields
                {
                    Comments = new List<TaskComment>
                    {
                        new TaskComment
                        {
                            TaskId = 1,
                            Date = DateTime.Now,
                            Username = "Lukas28",
                            Comment = "This is a comment!!!!!!!!!!"
                        }
                    }
                }
            });
        }

        private static void CreateSubTasks(TaskHandler taskHandler)
        {
            taskHandler.CreateSubTask(new Message
            {
                Method = "create",
                Resource = "subtask",
                Fields = new Fields
                {
                    SubTasks = new List<SubTask>
                    {
                        new SubTask
                        {
                            TaskId = 1,
                            IsComplete = false,
                            Description = "Do stuff",
                            EndTime = new DateTime(2019, 12, 20),
                            ColorLabel = "primary"
                        }
                    }
                }
            });

            taskHandler.CreateSubTask(new Message
            {
                Method = "create",
                Resource = "subtask",
                Fields = new Fields
                {
                    SubTasks = new List<SubTask>
                    {
                        new SubTask
                        {
                            TaskId = 1,
                            IsComplete = false,
                            Description = "Do stuff2",
                            EndTime = new DateTime(2019, 12, 20),
                            ColorLabel = "primary"
                        }
                    }
                }
            });

            taskHandler.CreateSubTask(new Message
            {
                Method = "create",
                Resource = "subtask",
                Fields = new Fields
                {
                    SubTasks = new List<SubTask>
                    {
                        new SubTask
                        {
                            TaskId = 1,
                            IsComplete = false,
                            Description = "Do stuff3",
                            EndTime = new DateTime(2019, 12, 20),
                            ColorLabel = "primary"
                        }
                    }
                }
            });
        }

        private static void CreateMessages(ChannelHandler ChannelHandler)
        {
            ChannelHandler.SendMessage(new Message
            {
                Resource = "channel",
                Method = "sendmessage",
                Fields = new Fields
                {
                    ChannelMessages = new List<CMessage>
                    {
                        new CMessage
                        {
                            Sender = "Andrei111",
                            ChannelId = 2,
                            Content = "Hello my name is Andrei"
                        }
                    }
                }
            });

            ChannelHandler.SendMessage(new Message
            {
                Resource = "channel",
                Method = "sendmessage",
                Fields = new Fields
                {
                    ChannelMessages = new List<CMessage>
                    {
                        new CMessage
                        {
                            Sender = "Lukas28",
                            ChannelId = 2,
                            Content = "Hello my name is Lukas"
                        }
                    }
                }
            });
            ChannelHandler.SendMessage(new Message
            {
                Resource = "channel",
                Method = "sendmessage",
                Fields = new Fields
                {
                    ChannelMessages = new List<CMessage>
                    {
                        new CMessage
                        {
                            Sender = "Deivydas111",
                            ChannelId = 2,
                            Content = "Hello my name is deividas"
                        }
                    }
                }
            });
        }

        private static void AddUsersToChannels(ChannelHandler channelHandler)
        {
            channelHandler.AddUserToChannel(3, "Andrei111");
            channelHandler.AddUserToChannel(3, "Deivydas111");
            channelHandler.AddUserToChannel(2, "Andrei111");
            channelHandler.AddUserToChannel(2, "Deivydas111");
        }

        private static void CreateChannels(ChannelHandler channelHandler)
        {
            channelHandler.CreateChannel(new Message
            {
                Method = "create",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            ProjectId = 1,
                            Title = "IT Department"
                        }
                    }
                }
            });

            channelHandler.CreateChannel(new Message
            {
                Method = "create",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            ProjectId = 1,
                            Title = "Other Department"
                        }
                    }
                }
            });

            channelHandler.CreateChannel(new Message
            {
                Method = "create",
                Resource = "channel",
                Fields = new Fields
                {
                    Channels = new List<Channel>
                    {
                        new Channel
                        {
                            ProjectId = 1,
                            Title = "Business Department"
                        }
                    }
                }
            });
        }

        private static void CreateTaskComments()
        {
        }

        private static void CreateRandomTasks(TaskHandler TaskHandler)
        {
            TaskHandler.CreateTask(new Message //#ff0000
            {
                Method = "create",
                Resource = "task",
                Fields = new Fields
                {
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            IsComplete = false,
                            Username = "Andrei111",
                            ProjectId = 1,
                            Description = "Do stuff",
                            StartTime = DateTime.Now,
                            EndTime = new DateTime(2019, 12, 20),
                            ColorLabel = "danger"
                        }
                    }
                }
            });

            TaskHandler.CreateTask(new Message //#ff0000
            {
                Method = "create",
                Resource = "task",
                Fields = new Fields
                {
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            IsComplete = false,
                            Username = "Andrei111",
                            ProjectId = 1,
                            Description = "Do stuff 2",
                            StartTime = DateTime.Now,
                            EndTime = new DateTime(2019, 12, 21),
                            ColorLabel = "info"
                        }
                    }
                }
            });

            TaskHandler.CreateTask(new Message //#ff0000
            {
                Method = "create",
                Resource = "task",
                Fields = new Fields
                {
                    Tasks = new List<Task>
                    {
                        new Task
                        {
                            IsComplete = false,
                            Username = "Andrei111",
                            ProjectId = 1,
                            Description = "Do stuff 3",
                            StartTime = DateTime.Now,
                            EndTime = new DateTime(2019, 12, 22),
                            ColorLabel = "primary"
                        }
                    }
                }
            });
        }

        private static void CreatePendingInvitations(ProjectHandler projectHandler)
        {
            projectHandler.AddPendingInvitation(new Message
            {
                Resource = "project",
                Method = "invite",
                Fields = new Fields
                {
                    PendingInvitation = new PendingInvitation
                    {
                        Username = "Andrei111",
                        ProjectId = 1
                    }
                }
            });
        }

        private static void CreateUsers(UserHandler userHandler)
        {
            userHandler.RegisterUser(new Message
            {
                Resource = "user",
                Method = "register",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = "Andrei111",
                        FirstName = "Andrei",
                        LastName = "Balanuta",
                        Gender = "M"
                    },
                    Password = "123"
                }
            });

            userHandler.RegisterUser(new Message
            {
                Resource = "user",
                Method = "register",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = "Deivydas111",
                        FirstName = "Deivydas",
                        LastName = "Zibkus",
                        Gender = "M"
                    },
                    Password = "123"
                }
            });

            userHandler.RegisterUser(new Message
            {
                Resource = "user",
                Method = "register",
                Fields = new Fields
                {
                    User = new User
                    {
                        Username = "Lukas28",
                        FirstName = "Lukas",
                        LastName = "Vaisnoras",
                        Gender = "M"
                    },
                    Password = "123"
                }
            });
        }

        private static void CreateProjects(ProjectHandler projectHandler)
        {
            projectHandler.CreateProject(new Message
            {
                Method = "create",
                Resource = "project",
                Fields = new Fields
                {
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Title = "MyProject1",
                            Description = "This is my first project!",
                            OwnerUsername = "Lukas28"
                        }
                    }
                }
            });

            projectHandler.CreateProject(new Message
            {
                Method = "create",
                Resource = "project",
                Fields = new Fields
                {
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Title = "MyProject2",
                            Description = "This is my second project!",
                            OwnerUsername = "Lukas28"
                        }
                    }
                }
            });

            projectHandler.CreateProject(new Message
            {
                Method = "create",
                Resource = "project",
                Fields = new Fields
                {
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Title = "MyProject3",
                            Description = "This is my third project!",
                            OwnerUsername = "Lukas28"
                        }
                    }
                }
            });
        }
    }
}
