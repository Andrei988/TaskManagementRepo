using Microsoft.AspNetCore.Mvc;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Handlers;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase

    {
        private readonly IProjectHandler ProjectHandler;

        public ProjectController(Context Context)
        {
            ProjectHandler = new ProjectHandler(Context);
        }

        [HttpPut]
        [Route("create")]
        public IActionResult Put([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(ProjectHandler.CreateProject(message));
        }

        [HttpGet("{username}")]
        public string GetProjects(string username)
        {
            return "{" + ProjectHandler.GetProjects(username) + "}";
        }

        [Route("Users/{id:int}")]
        [HttpGet]
        public IActionResult GetProjectUsers(int id)
        {
            return Ok(ProjectHandler.GetAllUsers(id));
        }

        [Route("Info/{id:int}")]
        [HttpGet]
        public IActionResult GetProjectInfo(int id)
        {
            return Ok("{" + ProjectHandler.GetProjectInfo(id) + "}");
        }

        [HttpPost]
        [Route("Invite")]
        public IActionResult Invite(Message Message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(ProjectHandler.AddPendingInvitation(Message));
        }

        [HttpPost]
        [Route("InviteAccept")]
        public IActionResult InviteAccept(Message Message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(ProjectHandler.AcceptPendingInvitation(Message));
        }

        [HttpPost]
        [Route("InviteDecline")]
        public IActionResult InviteDecline(Message Message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(ProjectHandler.DeclinePendingInvitation(Message));
        }

        [HttpDelete]
        [Route("Delete/{username}/{id:int}")]
        public IActionResult DeleteUserFromProject(string username, int id)
        {
            return Ok(ProjectHandler.DeleteUserFromProject(username, id));
        }

        [Route("Invitations/{username}")]
        [HttpGet]
        public IActionResult GetUserPendingInvitations(string username)
        {
            return Ok(ProjectHandler.GetUserPendingInvitations(username));
        }
    }
}
