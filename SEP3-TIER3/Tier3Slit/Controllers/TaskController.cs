using Microsoft.AspNetCore.Mvc;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Handlers;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskHandler TaskHandler;

        public TaskController(Context Context)
        {
            TaskHandler = new TaskHandler(Context);
        }

        // Tasks

        [HttpPut]
        [Route("create")]
        public IActionResult CreateTask([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.CreateTask(message));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteTask(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.DeleteTask(id));
        }

        [HttpGet]
        [Route("project/{username}/{id:int}")]
        public IActionResult GetUserProjectTasks(string username, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.GetUserProjectTasks(username, id));
        }

        [HttpGet]
        [Route("project/{id:int}")]
        public IActionResult GetAllProjectTasks(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok("{" + TaskHandler.GetAllProjectTasks(id) + "}");
        }

        [HttpPut]
        [Route("comment/create")]
        public IActionResult CreateComment([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.AddComment(message));
        }

        [HttpDelete]
        [Route("comment/{id:int}")]
        public IActionResult DeleteComment(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.DeleteComment(id));
        }

        [HttpGet]
        [Route("comment/{id:int}")]
        public IActionResult GetTaskComments(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok("{" + TaskHandler.GetTaskComments(id) + "}");
        }


        // SubTasks

        [HttpPut]
        [Route("subtask/create")]
        public IActionResult CreateSubTask([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.CreateSubTask(message));
        }

        [HttpDelete]
        [Route("subtask/{id:int}")]
        public IActionResult DeleteSubTask(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.DeleteSubTask(id));
        }

        [HttpPost]
        [Route("subtask/{id:int}")]
        public IActionResult SetSubTaskComplete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(TaskHandler.SetSubTaskComplete(id));
        }

        [HttpGet]
        [Route("subtask/{id:int}")]
        public IActionResult GetAllTaskSubTasks(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok("{" + TaskHandler.GetAllTaskSubTasks(id) + "}");
        }
    }
}
