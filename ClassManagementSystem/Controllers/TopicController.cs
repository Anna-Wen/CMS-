using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassManagementSystem.Models;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/Topic")]
    public class TopicController : Controller
    {

        // GET: /Topic/{topicId}
        [HttpGet("{topicId}")]
        public IActionResult GetTopic(int topicId)
        {
            Topic topic = new Topic { Id = 257, Serial = "A", Name = "领域模型与模块划分", Description = "Domain Model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 };

            return Json(topic);
        }

        // PUT: /Topic/{topicId}
        [HttpPut("{topicId}")]
        public IActionResult PutTopic(int topicId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /Topic/{topicId}
        [HttpDelete("{topicId}")]
        public IActionResult DeleteTopic(int topicId)
        {
            return Ok();
        }

        // GET: /Topic/{topicId}/group
        [HttpGet("{topicId}/group")]
        public IActionResult GetGroupsUnderTopic(int topicId)
        {
            return Ok();
        }
    }
}
