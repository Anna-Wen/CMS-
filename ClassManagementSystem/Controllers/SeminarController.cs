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
        // GET: /Seminar/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetSeminar(int seminarId)
        {
            Seminar seminar = new Seminar { Id = seminarId, Name = "概要设计", Description = "本节讨论课的主要内容针对第一二章", GroupingMethod = "fixed", StartTime = "11/10/2017", EndTime = "17/11/2017" };

            return Json(seminar);
        }

        // GET: /Seminar/5/topic
        [HttpGet("{id}/topic")]
        public IActionResult GetSeminarTopics(int seminarId)
        {
            List<Topic> topics = new List<Topic>();
            topics.Add(new Topic { Id = 257, Name = "Domain model 与模块划分", Description = "XXXXXXXX", GroupLimit = 3 });
            topics.Add(new Topic { Id = 257, Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5 });

            return Json(topics);
        }

        /*
        // POST: api/Seminar
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Seminar/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
