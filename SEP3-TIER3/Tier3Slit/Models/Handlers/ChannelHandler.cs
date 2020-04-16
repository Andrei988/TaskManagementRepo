using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Entities;

namespace Tier3Slit.Models.Handlers
{
    public class ChannelHandler : IChannelHandler
    {
        private readonly Context Context;

        public ChannelHandler(Context Context)
        {
            this.Context = Context;
        }

        public string CreateChannel(Message message)
        {
            try
            {
                List<Channel> messageChannels = new List<Channel>(message.Fields.Channels.OfType<Channel>());

                Project dbEntry = Context.Projects.Find(messageChannels[0].Id);

                if (dbEntry == null)
                {
                    try
                    {
                        var p = new Channel
                        {
                            Title = messageChannels[0].Title,
                            ProjectId = messageChannels[0].ProjectId,
                        };

                        Context.Channels.Add(p);
                        Context.SaveChanges();


                        var pc = new ProjectChannel
                        {
                            ProjectId = p.ProjectId,
                            ChannelId = (from x in Context.Channels
                                where x.Title == p.Title
                                select x.Id).FirstOrDefault()
                        };

                        Context.ProjectChannels.Add(pc);

                        Context.SaveChanges();

                        var project = (from x in Context.Projects
                            where x.Id == p.ProjectId
                            select x).FirstOrDefault();

                        var admin = (from x in Context.Users
                            where x.Username == project.OwnerUsername
                            select x).FirstOrDefault();

                        var cu = new ChannelUser
                        {
                            ChannelId = (from x in Context.Channels
                                where x.Title == p.Title
                                select x.Id).FirstOrDefault(),
                            Username = admin.Username
                        };

                        Context.ChannelUser.Add(cu);
                        Context.SaveChanges();

                        return JsonConvert.SerializeObject(new Message("channel", "create", 201, "Channel created"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        return JsonConvert.SerializeObject(new Message("channel", "create", 500, "Bad request"));
                    }
                }

                return JsonConvert.SerializeObject(new Message("channel", "create", 200, "Channel exists"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "create", 500, e.Message));
            }
        }

        public string AddUserToChannel(int channelId, string username)
        {
            try
            {
                var dbEntry = (from x in Context.ChannelUser
                    where x.Username == username && x.ChannelId == channelId
                    select x).FirstOrDefault();

                if (dbEntry == null)
                {
                    var user = (from x in Context.Users
                        where x.Username == username
                        select x).FirstOrDefault();

                    var channel = (from x in Context.Channels
                        where x.Id == channelId
                        select x).FirstOrDefault();

                    var cu = new ChannelUser
                    {
                        ChannelId = channelId,
                        Username = username,
                        User = user,
                        Channel = channel
                    };

                    Context.ChannelUser.Add(cu);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("channel", "adduser", 200, "User added to channel"));
                }

                return JsonConvert.SerializeObject(new Message("channel", "adduser", 200, "User already exists"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "adduser", 500, e.Message));
            }
        }

        public string DeleteUserFromChannel(int channelId, string username)
        {
            try
            {
                var dbEntry = (from x in Context.ChannelUser
                    where x.Username == username && x.ChannelId == channelId
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    Context.ChannelUser.Remove(dbEntry);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 202, "User deleted"));
                }

                return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 404, "User not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 500, e.Message));
            }
        }


        public string GetChannels(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.Channels
                    where x.ProjectId == Id
                    select x).ToList();

                if (dbEntry != null || dbEntry.Count != 0)
                {
                    Message m = new Message
                    {
                        Method = "getchannels",
                        Resource = "channel",
                        Fields = new Fields
                        {
                            Channels = dbEntry,
                            ResponseDescription = "Channels returned",
                            ResponseCode = 200
                        }
                    };

                    return JsonConvert.SerializeObject(m);
                }

                return JsonConvert.SerializeObject(new Message("channel", "getchannels", 404, "Channels not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "getchannels", 500, e.Message));
            }
        }

        public string GetChannelUsers(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.ChannelUser
                    where x.ChannelId == Id
                    select x).ToList();

                if (dbEntry != null)
                {
                    Message m = new Message
                    {
                        Method = "getchannelusers",
                        Resource = "channel",
                        Fields = new Fields
                        {
                            ChannelUsers = dbEntry,
                            ResponseCode = 200,
                            ResponseDescription = "Users from channel returned"
                        }
                    };

                    return JsonConvert.SerializeObject(m);
                }

                return JsonConvert.SerializeObject(new Message("channel", "getchannelusers", 404,
                    "No users in the channel"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "getchannelusers", 500, e.Message));
            }
        }

        public string GetChannelMessages(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.ChannelMessages
                    where x.ChannelId == Id
                    select x).ToList();

                if (dbEntry != null)
                {
                    dbEntry.Sort();

                    var channelusers = (from x in Context.ChannelUser
                        where x.ChannelId == Id
                        select x).ToList();

                    Message m = new Message
                    {
                        Method = "initchat",
                        Resource = "channel",
                        Fields = new Fields
                        {
                            ChannelMessages = dbEntry,
                            ChannelUsers = channelusers,
                            ResponseCode = 200,
                            ResponseDescription = "Chat returned"
                        }
                    };

                    return JsonConvert.SerializeObject(m);
                }


                return JsonConvert.SerializeObject(new Message("channel", "initchat", 500, "No messages found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "initchat", 500, e.Message));
            }
        }

        public string SendMessage(Message Message)
        {
            try
            {
                var messages = Message.Fields.ChannelMessages;
                var message = messages[0];
                message.TimeSent = DateTime.Now;


                if (message != null)
                {
                    Context.ChannelMessages.Add(message);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 201, "Message sent"));
                }

                return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 500, "Deserialize error"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "deleteuser", 500, e.Message));
            }
        }

        public string DeleteChannel(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.Channels
                    where x.Id == Id
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    var channelUsers = (from x in Context.ChannelUser
                        where x.ChannelId == Id
                        select x).ToList();

                    foreach (var channelUser in channelUsers)
                    {
                        Context.ChannelUser.Remove(channelUser);
                    }

                    Context.Channels.Remove(dbEntry);

                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("channel", "deletechanne", 202, "Channel deleted"));
                }

                return JsonConvert.SerializeObject(new Message("channel", "deletechanne", 404, "Channel not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("channel", "deletechanne;", 500, e.Message));
            }
        }
    }
}
