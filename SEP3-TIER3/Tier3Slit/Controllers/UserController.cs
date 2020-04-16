using Microsoft.AspNetCore.Mvc;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Handlers;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserHandler UserHandler;

        public UserController(Context Context)
        {
            UserHandler = new UserHandler(Context);
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(UserHandler.Login(message));
        }

        [Route("password")]
        [HttpPost]
        public IActionResult ChangePassword([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(UserHandler.ChangePassword(message));
        }

        [HttpPut]
        [Route("register")]
        public IActionResult Put([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(UserHandler.RegisterUser(message));
        }

        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            return Ok("{" + UserHandler.GetInfo(username) + "}");
        }
    }
}
