using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Entities;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Models.Handlers
{
    public class ProjectHandler : IProjectHandler
    {
        private readonly Context Context;

        public ProjectHandler(Context Context)
        {
            this.Context = Context;
        }

        public string CreateProject(Message message)
        {
            try
            {
                List<Project> messageProjects = new List<Project>(message.Fields.Projects.OfType<Project>());

                Project dbEntry = Context.Projects.Find(messageProjects[0].Id);

                if (dbEntry == null)
                {
                    var p = new Project
                    {
                        Title = messageProjects[0].Title,
                        OwnerUsername = messageProjects[0].OwnerUsername,
                        Description = messageProjects[0].Description
                    };

                    Context.Projects.Add(p);
                    Context.SaveChanges();

                    var pr = (from s in Context.Projects
                        where s.Title == p.Title
                        select s).FirstOrDefault<Project>();

                    Context.Add(new ProjectUser
                    {
                        ProjectId = pr.Id,
                        Username = messageProjects[0].OwnerUsername
                    });

                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("project", "create", 201, "Project created"));
                }

                return JsonConvert.SerializeObject(new Message("project", "create", 500, "Project exists"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string GetProjects(string username)
        {
            try
            {
                var join = (from j in Context.ProjectUser
                    where j.Username == username
                    select j).ToList();

                List<Project> projects = new List<Project>();

                foreach (var j in join)
                {
                    var project = (from p in Context.Projects
                        where p.Id == j.ProjectId
                        select p).FirstOrDefault<Project>();


                    project.Users = null;
                    projects.Add(project);
                }

                return JsonConvert.SerializeObject(new Message
                {
                    Method = "userprojects",
                    Resource = "project",
                    Fields = new Fields
                    {
                        Projects = projects,
                        ResponseCode = 200,
                        ResponseDescription = "Projects returned"
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string GetAllUsers(int Id)
        {
            try
            {
                var join = (from j in Context.ProjectUser
                    where j.ProjectId == Id
                    select j).ToList();
                return JsonConvert.SerializeObject(new Message
                {
                    Resource = "user",
                    Method = "getprojectusers",
                    Fields = new Fields
                    {
                        Projects = new List<Project>
                        {
                            new Project
                            {
                                Users = join
                            }
                        },
                        ResponseCode = 200,
                        ResponseDescription = "Users returned"
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("user", "getprojectusers", 500, e.Message));
            }
            
        }

        public string DeleteUserFromProject(string username, int id)
        {
            try
            {
                var dbEntry = (from x in Context.Users
                    where x.Username == username
                    select x).FirstOrDefault();

                var dbEntry2 = (from x in Context.ProjectUser
                    where x.Username == username && x.ProjectId == id
                    select x).FirstOrDefault();

                if (dbEntry == null)
                {
                    return JsonConvert.SerializeObject(
                        new Message("project", "deleteuser", 404, "User not found"));
                }

                if (dbEntry2 == null)
                {
                    return JsonConvert.SerializeObject(
                        new Message("project", "deleteuser", 404, "User in project not found"));
                }


                Context.ProjectUser.Remove(dbEntry2);
                Context.SaveChanges();
                return JsonConvert.SerializeObject(
                    new Message("project", "deleteuser", 202, "User deleted from project"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(
                    new Message("project", "deleteuser", 500, e.Message));
            }
        }

        public string DeclinePendingInvitation(Message Message)
        {
            try
            {
                var invitation = Message.Fields.PendingInvitation;

                var dbEntry = (from x in Context.PendingInvitation
                    where x.Username == invitation.Username && x.ProjectId == invitation.ProjectId
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    Context.PendingInvitation.Remove(dbEntry);
                    Context.SaveChanges();

                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 200, "Invitation Declined"));
                }

                return JsonConvert.SerializeObject(
                    new Message("project", "invite", 404, "Pending invitation not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(
                    new Message("project", "invite", 500, e.Message));
            }
        }

        public string AcceptPendingInvitation(Message Message)
        {
            try
            {
                var invitation = Message.Fields.PendingInvitation;

                var dbEntry = (from x in Context.PendingInvitation
                    where x.Username == invitation.Username && x.ProjectId == invitation.ProjectId
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    Context.PendingInvitation.Remove(dbEntry);

                    ProjectUser projectUser = new ProjectUser
                    {
                        Username = invitation.Username,
                        ProjectId = invitation.ProjectId,
                        Project = (from x in Context.Projects
                            where x.Id == invitation.ProjectId
                            select x).FirstOrDefault(),
                        User = (from x in Context.Users
                            where x.Username == invitation.Username
                            select x).FirstOrDefault()
                    };

                    Context.ProjectUser.Add(projectUser);

                    Context.SaveChanges();

                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 200, "Invitation accepted"));
                }

                return JsonConvert.SerializeObject(
                    new Message("project", "invite", 404, "Pending invitation not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(
                    new Message("project", "invite", 500, e.Message));
            }
        }

        public string GetUserPendingInvitations(string username)
        {
            try
            {
                var dbEntry = (from x in Context.PendingInvitation
                    where x.Username == username
                    select x).ToList();

                if (dbEntry.Count == 0)
                {
                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 404, "No invitations found"));
                }

                return JsonConvert.SerializeObject(dbEntry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "invite", 500, e.Message));
            }
        }

        public string AddPendingInvitation(Message Message)
        {
            try
            {
                var invitation = Message.Fields.PendingInvitation;

                var dbEntry = (from x in Context.PendingInvitation
                    where x.Username == invitation.Username && x.ProjectId == invitation.ProjectId
                    select x).FirstOrDefault();

                var dbEntry1 = (from x in Context.ProjectUser
                    where x.Username == invitation.Username && x.ProjectId == invitation.ProjectId
                    select x).FirstOrDefault();

                var dbEntry2 = (from x in Context.Users
                    where x.Username == invitation.Username
                    select x).FirstOrDefault();

                var dbEntry3 = (from x in Context.Projects
                    where x.Id == invitation.ProjectId
                    select x).FirstOrDefault();

                if (dbEntry3 == null)
                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 404, "Project not found"));

                if (dbEntry2 == null)
                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 404, "User not found"));

                if (dbEntry1 != null)
                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 200, "User is already in the project"));

                if (dbEntry == null)
                {
                    Context.PendingInvitation.Add(invitation);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(
                        new Message("project", "invite", 200, "User invitation created"));
                }

                return JsonConvert.SerializeObject(new Message("project", "invite", 200, "User already invited"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "invite", 500, e.Message));
            }
        }

        public string GetProjectInfo(int Id)
        {
            try
            {
                var p = (from x in Context.Projects
                    where x.Id == Id
                    select x).FirstOrDefault();

                return JsonConvert.SerializeObject(new Message
                {
                    Resource = "project",
                    Method = "getinfo",
                    Fields = new Fields
                    {
                        Projects = new List<Project>
                        {
                            new Project
                            {
                                Id = p.Id,
                                Description = p.Description,
                                Title = p.Title,
                                OwnerUsername = p.OwnerUsername,
                                Users = p.Users
                            }
                        },
                        ResponseCode = 200,
                        ResponseDescription = "Project info returned"
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "getinfo", 500, e.Message));
            }
        }
    }
}
