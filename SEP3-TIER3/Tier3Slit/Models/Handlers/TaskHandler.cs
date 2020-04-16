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
    public class TaskHandler : ITaskHandler
    {
        private readonly Context Context;

        public TaskHandler(Context Context)
        {
            this.Context = Context;
        }

        public string CreateTask(Message Message)
        {
            try
            {
                var rcvTasks = Message.Fields.Tasks as List<Task>;
                var rcvTask = rcvTasks[0];

                var dbEntry = (from t in Context.Tasks
                    where t.Description == rcvTask.Description
                    select t).FirstOrDefault();

                var userCheck = (from x in Context.ProjectUser
                    where x.Username == rcvTask.Username && x.ProjectId == rcvTask.ProjectId
                    select x).FirstOrDefault();

                if (userCheck.Username != null && userCheck.ProjectId != 0)
                {
                    if (dbEntry == null)
                    {
                        var task = new Task
                        {
                            IsComplete = false,
                            Username = rcvTask.Username,
                            ProjectId = rcvTask.ProjectId,
                            Description = rcvTask.Description,
                            StartTime = DateTime.Now,
                            EndTime = rcvTask.EndTime,
                            ColorLabel = rcvTask.ColorLabel
                        };

                        Context.Tasks.Add(task);
                        Context.SaveChanges();

                        return JsonConvert.SerializeObject(new Message("project", "create", 201, "Task created"));
                    }

                    return JsonConvert.SerializeObject(new Message("project", "create", 201, "Task already exists"));
                }

                return JsonConvert.SerializeObject(new Message("project", "create", 404,
                    "User not found in the project"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string DeleteTask(int id)
        {
            try
            {
                var dbEntry = (from t in Context.Tasks
                    where t.Id == id
                    select t).FirstOrDefault();


                if (dbEntry != null)
                {
                    Context.Tasks.Remove(dbEntry);
                    Context.SaveChanges();

                    return JsonConvert.SerializeObject(new Message("project", "create", 200, "Task deleted"));
                }

                return JsonConvert.SerializeObject(new Message("project", "create", 404, "Task not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string GetAllProjectTasks(int id)
        {
            try
            {
                var tasks = (from x in Context.Tasks
                    where x.ProjectId == id
                    select x).ToList();

                var message = new Message
                {
                    Method = "projecttasks",
                    Resource = "task",

                    Fields = new Fields
                    {
                        Tasks = tasks,
                        ResponseCode = 200,
                        ResponseDescription = "Project tasks returned"
                    }
                };

                return JsonConvert.SerializeObject(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string GetUserProjectTasks(string username, int projectId)
        {
            try
            {
                var userTasks = (from x in Context.Tasks
                    where x.Username == username
                    select x).ToList();

                var tasks = new List<Task>();

                foreach (var userTask in userTasks)
                {
                    if (userTask.ProjectId == projectId)
                        tasks.Add(userTask);
                }

                var returnMessage = new Message
                {
                    Method = "userprojecttasks",
                    Resource = "task",
                    Fields = new Fields
                    {
                        Tasks = tasks,
                        ResponseCode = 200,
                        ResponseDescription = "Tasks returned"
                    }
                };

                return JsonConvert.SerializeObject(returnMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("project", "create", 500, e.Message));
            }
        }

        public string CreateSubTask(Message Message)
        {
            try
            {
                var subtasks = Message.Fields.SubTasks as List<SubTask>;
                var subtask = subtasks[0];

                var dbEntry = (from x in Context.SubTasks
                    where x.Description == subtask.Description
                    select x).FirstOrDefault();

                if (dbEntry == null)
                {
                    subtask.StartTime = DateTime.Now;
                    Context.SubTasks.Add(subtask);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("subtask", "create", 201, "Subtask created"));
                }


                return JsonConvert.SerializeObject(new Message("subtask", "create", 200, "Subtask exists"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("subtask", "create", 500, e.Message));
            }
        }

        public string DeleteSubTask(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.SubTasks
                    where x.Id == Id
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    Context.SubTasks.Remove(dbEntry);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("subtask", "delete", 200, "Subtask deleted"));
                }

                return JsonConvert.SerializeObject(new Message("subtask", "delete", 404, "Subtask not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("subtask", "delete", 500, e.Message));
            }
        }

        public string SetSubTaskComplete(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.SubTasks
                    where x.Id == Id
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    dbEntry.IsComplete = true;
                    Context.SubTasks.Update(dbEntry);
                    Context.SaveChanges();

                    var subTaskList = (from x in Context.SubTasks
                        where x.TaskId == dbEntry.TaskId
                        select x).ToList();

                    bool flag = true;

                    foreach (var subTask in subTaskList)
                    {
                        if (subTask.IsComplete == false)
                            flag = false;
                    }

                    if (flag)
                    {
                        var task = (from x in Context.Tasks
                            where x.Id == dbEntry.TaskId
                            select x).FirstOrDefault();

                        task.IsComplete = true;
                        Context.Tasks.Update(task);
                        Context.SaveChanges();
                    }

                    
                    return JsonConvert.SerializeObject(new Message("subtask", "setcomplete", 200, "Subtask set complete"));
                }

                return JsonConvert.SerializeObject(new Message("subtask", "setcomplete", 404, "Subtask not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("subtask", "create", 500, e.Message));
            }
        }

        public string GetAllTaskSubTasks(int Id)
        {
            try
            {
                var dbEntry = (from x in Context.SubTasks
                    where x.TaskId == Id
                    select x).ToList();

                if (dbEntry != null)
                {
                    var dbEntry2 = (from x in Context.TaskComment
                        where x.TaskId == Id
                        select x).ToList();

                    Message m = new Message
                    {
                        Resource = "subtask",
                        Method = "getsubtasks",
                        Fields = new Fields
                        {
                            SubTasks = dbEntry,
                            Comments = dbEntry2,
                            ResponseCode = 200,
                            ResponseDescription = "Subtask returned"
                        }
                    };

                    return JsonConvert.SerializeObject(m);
                }
                return JsonConvert.SerializeObject(new Message("subtask", "getsubtasks", 404, "No subtasks found"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("subtask", "getsubtasks", 500, e.Message));
            }
        }

        public string GetTaskComments(int id)
        {
            try
            {

                var dbEntry = (from x in Context.TaskComment
                    where x.TaskId == id
                    select x).ToList();

                if (dbEntry != null)
                {
                    Message message = new Message
                    {
                        Resource = "comment",
                        Method = "getcomments",
                        Fields = new Fields
                        {
                            Comments = dbEntry,
                            ResponseCode = 200,
                            ResponseDescription = "Comments returned"
                        }
                    };

                    return JsonConvert.SerializeObject(message);
                }
                return JsonConvert.SerializeObject(new Message("comment", "getcomments", 404, "No comments found"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("comment", "getcomments", 500, e.Message));
            }
        }

        public string AddComment(Message message)
        {
            try
            {

                var comments = message.Fields.Comments as List<TaskComment>;
                var comment = comments[0];

                var task = (from x in Context.Tasks
                    where x.Id == comment.TaskId
                    select x).FirstOrDefault();

                if (comment != null && task != null)
                {
                    Context.TaskComment.Add(comment);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("task", "addcomment", 201, "Comment created"));
                }
                return JsonConvert.SerializeObject(new Message("task", "addcomment", 404, "Comment not saved"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("task", "addcomment", 500, e.Message));
            }
        }

        public string DeleteComment(int id)
        {
            try
            {

                var dbEntry = (from x in Context.TaskComment
                    where x.Id == id
                    select x).FirstOrDefault();

                if (dbEntry != null)
                {
                    Context.TaskComment.Remove(dbEntry);
                    Context.SaveChanges();
                    return JsonConvert.SerializeObject(new Message("task", "deletecomment", 202, "Comment deleted"));

                }
                return JsonConvert.SerializeObject(new Message("task", "deletecomment", 404, "Comment not found"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return JsonConvert.SerializeObject(new Message("task", "deletecomment", 500, e.Message));
            }
        }

    }
}
