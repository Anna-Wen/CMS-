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
        List<Group> groups = new List<Group>();

        // GET: /seminar/{seminarId}
        [HttpGet("{seminarId}", Name = "Get")]
        public IActionResult GetSeminar(int seminarId)
        {
            // Fetch data from database
            List<Topic> topics = new List<Topic>();
            topics.Add(new Topic { Id = 257, Name = "领域模型与模块" });
            Seminar seminar = new Seminar { Id = 32, Name = "概要设计", Description = "本节讨论课的主要内容针对第一二章", GroupingMethod = "fixed", StartTime = "10/10/2017", EndTime = "24/10/2017", Topics = topics };

            // If seminar not found
            if (seminar == null)
                return NotFound();

            // Success
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
            GradeProportion proportions = new GradeProportion { Report = int.Parse(json.Proportions.Report), Presentation = int.Parse(json.Proportions.Presentation), C = int.Parse(json.Proportions.C), B = int.Parse(json.Proportions.B), A = int.Parse(json.Proportions.A) };
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
            // Fetch data from database
            SeminarDetail seminarDetail = new SeminarDetail { Id = 1, Name = "概要设计", StartTime = "10/10/2017", EndTime = "24/10/2017", Site = "海韵教学楼201", TeacherName = "邱明", TeacherEmail = "mingqiu@xmu.edu.cn" };

            // If seminar not found
            if (seminarDetail == null)
                return NotFound();

            // Success
            return Json(seminarDetail);
        }

        // GET: /seminar/{seminarId}/topic
        [HttpGet("{seminarId}/topic")]
        public IActionResult GetSeminarTopics(int seminarId)
        {
            // Fetch data from database
            List<Topic> topics = new List<Topic>();
            topics.Add(new Topic { Id = 257, Serial = "A", Name = "领域模型与模块", Description = "Domain model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 });
            topics.Add(new Topic { Id = 258, Serial = "B", Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5, GroupMemberLimit = 5, GroupLeft = 1 });


            // If seminar not found
            if (topics == null)
                return NotFound();

            // Success
            return Json(topics);
        }

        // POST: /seminar/{seminarId}/topic
        [HttpPost("{seminarId}/topic")]
        public IActionResult PostNewTopicUnderSeminar(int seminarId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Get information from json
            Topic newTopic = new Topic { Serial = json.Serial, Name = json.Name, Description = json.Description, GroupLimit = json.GroupLimit, GroupMemberLimit = json.GroupMemberLimit };

            // Store topic information in server and generate a id for this new topic
            newTopic.Id = 257;

            // Return topic id
            string uri = "/topic/" + newTopic.Id;
            return Created(uri, newTopic);
        }

        // GET: /seminar/{seminarId}/group
        [HttpGet("{seminarId}/group")]
        public IActionResult GetSeminarGroups(int seminarId, [FromQuery]bool gradeable, [FromQuery]int classId)
        {
            // Fetch data from database
            List<Group> groups = new List<Group>();


            // If seminar not found
            if (groups == null)
                return NotFound();

            // Success
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
