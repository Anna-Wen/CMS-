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
    [Route("/Seminar")]
    public class SeminarController : Controller
    {
        List<Seminar> seminars = new List<Seminar>();
        List<Topic> topics = new List<Topic>();
        List<Group> groups = new List<Group>();

        // GET: /seminar/5
        [HttpGet("{seminarId}", Name = "Get")]
        public IActionResult GetSeminar(int seminarId)
        {
            // Fake Data
            Seminar seminar = new Seminar { Id = 1, Name = "概要设计", Description = "本节讨论课的主要内容针对第一二章", GroupingMethod = "fixed", StartTime = "11/10/2017", EndTime = "17/11/2017" };
            if (seminars.FirstOrDefault((p) => p.Id == 1) == null)
                seminars.Add(seminar);

            return Json(seminar);
        }

        //// PUT: /seminar/{seminarId}
        //[HttpPut("{seminarId}")]
        //public IActionResult PutSeminar(int seminarId, [FromBody]string value)
        //{
        //}

        // DELETE: /seminar/{seminarId}
        [HttpDelete("{seminarId}")]
        public IActionResult DeleteSeminar(int seminarId)
        {
            Seminar target = seminars.FirstOrDefault((p) => p.Id == seminarId);
            if (target == null)
                return NotFound();
            else
            {
                seminars.Remove(target);
                return NoContent();
            }
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
        public IActionResult PostNewTopicUnderSeminar(int seminarId, [FromBody]Topic newTopic)
        {
            // Fake Data
            newTopic.Id = 23;

            topics.Add(newTopic);

            return Created("/seminar/{seminarId}", newTopic);
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
