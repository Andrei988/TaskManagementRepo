using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier3Slit.Communication;

namespace Tier3Slit.Models.Handlers.Interfaces
{
    interface ITaskHandler
    {
        string CreateTask(Message Message);
        string DeleteTask(int id);
        string GetAllProjectTasks(int id);
        string GetUserProjectTasks(string username, int projectId);
        string CreateSubTask(Message Message);
        string DeleteSubTask(int Id);
        string SetSubTaskComplete(int Id);
        string GetAllTaskSubTasks(int Id);
        string GetTaskComments(int id);
        string AddComment(Message message);
        string DeleteComment(int id);

    }
}
