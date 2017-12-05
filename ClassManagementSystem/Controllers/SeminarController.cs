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
    [Route("/seminar")]
    public class SeminarController : Controller
    {
        List<Seminar> seminars = new List<Seminar>();
        List<Topic> topics = new List<Topic>();
        List<Group> groups = new List<Group>();

        // GET: /seminar/{seminarId}
        [HttpGet("{seminarId}", Name = "Get")]
        public IActionResult GetSeminar(int seminarId)
        {
            // Fake Data
            Seminar seminar = new Seminar { Id = 1, Name = "概要设计", Description = "本节讨论课的主要内容针对第一二章", GroupingMethod = "fixed", StartTime = "11/10/2017", EndTime = "17/11/2017" };
            if (seminars.FirstOrDefault((p) => p.Id == 1) == null)
                seminars.Add(seminar);

            return Json(seminar);
        }

        // PUT: /seminar/{seminarId}
        [HttpPut("{seminarId}")]
        public IActionResult PutSeminar(int seminarId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //return Forbid();

            //Get information from json
            GradeProportion proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            Seminar editedSeminar = new Seminar { Name = json.Name, Description = json.Description, GroupingMethod = json.GroupingMethod, StartTime = json.StartTime, EndTime = json.EndTime, Proportions = proportions };

            //Change information in database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // DELETE: /seminar/{seminarId}
        [HttpDelete("{seminarId}")]
        public IActionResult DeleteSeminar(int seminarId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Delete seminar from database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // GET: /seminar/{seminarId}/detail
        [HttpGet("{seminarId}/detail")]
        public IActionResult GetSeminarDetails(int seminarId)
        {
            return Ok();
        }

        // GET: /seminar/{seminarId}/topic
        [HttpGet("{seminarId}/topic")]
        public IActionResult GetSeminarTopics(int seminarId)
        {
            // Fake Data
            if (topics.FirstOrDefault((p) => p.Id == 257) == null)
                topics.Add(new Topic { Id = 257, Name = "Domain model 与模块划分", Description = "XXXXXXXX", GroupLimit = 3 });
            if (topics.FirstOrDefault((p) => p.Id == 258) == null)
                topics.Add(new Topic { Id = 258, Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5 });

            return Json(topics);
        }

        // POST: /seminar/{seminarId}/topic
        [HttpPost("{seminarId}/topic")]
        public IActionResult PostNewTopicUnderSeminar(int seminarId, [FromBody]dynamic json)
        {
            //// Fake Data
            //newTopic.Id = 23;

            //topics.Add(newTopic);

            //return Created("/seminar/{seminarId}", newTopic);
            return Ok();
        }

        // GET: /seminar/{seminarId}/group
        [HttpGet("{seminarId}/group")]
        public IActionResult GetSeminarGroups(int seminarId)
        {
            List<Group> groups = new List<Group>();
            //topics.Add(new Topic { Id = 257, Name = "Domain model 与模块划分", Description = "XXXXXXXX", GroupLimit = 3 });
            //topics.Add(new Topic { Id = 257, Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5 });

            return Json(groups);
        }

        // GET: /seminar/{seminarId}/group/my
        [HttpGet("{seminarId}/group/my")]
        public IActionResult GetMySeminarGroup(int seminarId)
        {
            Group myGroup = groups.FirstOrDefault((p) => p.Id == "1A1");
          
            return Json(myGroup);
        }

    }
}
