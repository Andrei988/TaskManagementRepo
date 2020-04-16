using Microsoft.AspNetCore.Mvc;
using Tier3Slit.Communication;
using Tier3Slit.Data;
using Tier3Slit.Models.Handlers;
using Tier3Slit.Models.Handlers.Interfaces;

namespace Tier3Slit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {
        private readonly IChannelHandler channelHandler;

        public ChannelController(Context Context)
        {
            channelHandler = new ChannelHandler(Context);
        }

        [HttpPut]
        [Route("create")]
        public IActionResult CreateChannel([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.CreateChannel(message));
        }

        [HttpPost]
        [Route("User/{id:int}/{username}")]
        public IActionResult AddUserToChannel(int id, string username)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.AddUserToChannel(id, username));
        }

        [HttpDelete]
        [Route("Delete/{id:int}/{username}")]
        public IActionResult DeleteUserFromChannel(int id, string username)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.DeleteUserFromChannel(id, username));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteChannel(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.DeleteChannel(id));
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetChannels(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.GetChannels(id));
        }

        [HttpGet]
        [Route("users/{id:int}")]
        public IActionResult GetChannelUsers(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.GetChannelUsers(id));
        }

        [HttpGet]
        [Route("messages/{id:int}")]
        public IActionResult GetChannelMessages(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.GetChannelMessages(id));
        }

        [HttpPut]
        [Route("message")]
        public IActionResult SendMessage([FromBody] Message message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(channelHandler.SendMessage(message));
        }
    }
}
