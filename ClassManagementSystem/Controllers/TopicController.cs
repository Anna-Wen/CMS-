using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return Ok();
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
