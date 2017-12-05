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
            List<Topic> topics = new List<Topic>
            {
                new Topic { Id = 257, Name = "领域模型与模块" }
            };
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
<<<<<<< HEAD
            return Ok();
=======
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
>>>>>>> Anna's
        }

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
            List<Topic> topics = new List<Topic>
            {
                new Topic { Id = 257, Serial = "A", Name = "领域模型与模块", Description = "Domain model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 },
                new Topic { Id = 258, Serial = "B", Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5, GroupMemberLimit = 5, GroupLeft = 1 }
            };


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
            Topic newTopic = new Topic { Serial = json.Serial, Name = json.Name, Description = json.Description, GroupLimit = int.Parse(json.GroupLimit), GroupMemberLimit = int.Parse(json.GroupMemberLimit) };

            // Store topic information in server and generate a id for this new topic
            newTopic.Id = 257;

            // Return topic id
            string uri = "/topic/" + newTopic.Id;
            return Created(uri, newTopic);
        }

        // GET: /seminar/{seminarId}/group?classId={classId}
        [HttpGet("{seminarId}/group")]
        public IActionResult GetSeminarGroups(int seminarId, [FromQuery]bool gradeable, [FromQuery]int classId)
        {
            // Fetch data from database
            Student l1 = new Student { Id = 233, Name = "张三", Number = "24320152202333" };
            Student s1 = new Student { Id = 248, Name = "李四", Number = "24320152202345" };
            Student s2 = new Student { Id = 256, Name = "王五", Number = "24320152202356" };
            Student l2 = new Student { Id = 233, Name = "小红", Number = "24320152202456" };
            Student l3 = new Student { Id = 233, Name = "小紫", Number = "24320152202478" };
            Student l4 = new Student { Id = 233, Name = "小明", Number = "24320152202499" };
            List<Student> memberList = new List<Student> { s1, s2 };
            List<Topic> t1 = new List<Topic> { new Topic { Id = 257, Serial = "A", Name = "领域模型与模块", Description = "Domain model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 } };
            List<Topic> t2 = new List<Topic> { new Topic { Id = 258, Serial = "B", Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5, GroupMemberLimit = 5, GroupLeft = 1 } };
            List<Topic> t3 = new List<Topic> { new Topic { Id = 257, Serial = "A", Name = "领域模型与模块", Description = "Domain model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 },
                                                    new Topic { Id = 258, Serial = "B", Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5, GroupMemberLimit = 5, GroupLeft = 1 } };
            SeminarGrade sg1 = new SeminarGrade { PresentationGrade = new List<int> {5}, ReportGrade = 5, Grade = 5 };
            SeminarGrade sg2 = new SeminarGrade { PresentationGrade = new List<int> {4}, ReportGrade = 4, Grade = 4 };
            SeminarGrade sg3 = new SeminarGrade { PresentationGrade = new List<int> {5} };
            SeminarGrade sg4 = new SeminarGrade { PresentationGrade = new List<int> {4} };
            SeminarGrade sg5 = new SeminarGrade { PresentationGrade = new List<int> {5, 4} };
            
            List<Group> groups = new List<Group> {
                new Group { Id = 28, Name = "1-A-1", Leader = l1, Members = memberList, Topics = t1, Report = "/report/28.pdf", Grade = sg1 },
                new Group { Id = 29, Name = "1-A-2", Leader = s1, Members = memberList, Topics = t1, Report = "/report/29.pdf", Grade = sg2 },
                new Group { Id = 30, Name = "1-B-1", Leader = s2, Members = memberList, Topics = t2, Report = "/report/30.pdf", Grade = sg3 },
                new Group { Id = 31, Name = "2-A-1", Leader = l2, Members = memberList, Topics = t1, Report = "/report/31.pdf", Grade = sg4 },
                new Group { Id = 32, Name = "2-A-2", Leader = l3, Members = memberList, Topics = t1, Report = "", Grade = sg3 },
                new Group { Id = 33, Name = "3-A-1", Leader = l4, Members = memberList, Topics = t3, Report = "/report/33.pdf", Grade = sg5 }
            };

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
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            // Fetch data from database
            Student leader = new Student { Id = 233, Name = "张三", Number = "24320152202333" };
            Student s1 = new Student { Id = 248, Name = "李四", Number = "24320152202345" };
            Student s2 = new Student { Id = 256, Name = "王五", Number = "24320152202356" };
            List<Student> memberList = new List<Student> { s1, s2 };
            List<Topic> topics = new List<Topic> { new Topic { Id = 257, Serial = "A", Name = "领域模型与模块", Description = "Domain model 与模块划分", GroupLimit = 5, GroupMemberLimit = 6, GroupLeft = 2 } };
            Group myGroup = new Group { Id = 28, Name = "1-A-1", Leader = leader, Members = memberList, Topics = topics };

            // If seminar not found or no groups yet
            if (myGroup == null)
                return NotFound();

            // Success
            return Json(myGroup);
        }

    }
}
