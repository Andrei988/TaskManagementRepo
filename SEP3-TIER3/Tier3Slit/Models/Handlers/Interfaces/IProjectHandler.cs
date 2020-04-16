using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier3Slit.Communication;

namespace Tier3Slit.Models.Handlers.Interfaces
{
    interface IProjectHandler
    {
        string CreateProject(Message message);
        string GetProjects(string username);
        string GetAllUsers(int Id);
        string DeleteUserFromProject(string username, int id);
        string DeclinePendingInvitation(Message Message);
        string AcceptPendingInvitation(Message Message);
        string GetUserPendingInvitations(string username);
        string AddPendingInvitation(Message Message);
        string GetProjectInfo(int Id);

    }
}
