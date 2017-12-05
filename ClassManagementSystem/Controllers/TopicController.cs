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
    [Route("/topic")]
    public class TopicController : Controller
    {

        // GET: /topic/{topicId}
        [HttpGet("{topicId}")]
        public IActionResult GetTopic(int topicId)
        {
            //错误的Id格式返回400怎么写？？？

            // Fetch topic from database...
            Topic topic = new Topic { Id = 257, Serial = "A", Name = "领域模型与模块划分", Description = "Domain Model 与模块划分", GroupLimit = 6, GroupMemberLimit = 6, GroupLeft = 2 };

            // No topics found
            if (topic == null)
                return NotFound();

            return Json(topic);
        }

        // PUT: /topic/{topicId}
        [HttpPut("{topicId}")]
        public IActionResult PutTopic(int topicId, [FromBody]dynamic json)
        {
            //错误的Id格式返回400怎么写？？？

            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Get information from json
            Topic editedTopic = new Topic { Serial = json.Serial, Name = json.Name, Description = json.Description, GroupLimit = json.GroupLimit, GroupMemberLimit = json.GroupMemberLimit };

            //Change information in database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // DELETE: /topic/{topicId}
        [HttpDelete("{topicId}")]
        public IActionResult DeleteTopic(int topicId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Delete topic from database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // GET: /topic/{topicId}/group
        [HttpGet("{topicId}/group")]
        public IActionResult GetGroupsUnderTopic(int topicId)
        {
            //错误的Id格式返回400怎么写？？？

            // Fetch groups belongs to this topic via topicId from database...
            List<Group> groups = new List<Group>
            {
                new Group { Name = "1-A-1" },
                new Group { Name = "1-A-2" },
                new Group { Name = "1-A-3" },
                new Group { Name = "1-A-4" }
            };

            // No topics found
            if (groups == null)
                return NotFound();

            // Success
            return Json(groups);
        }
    }
}
