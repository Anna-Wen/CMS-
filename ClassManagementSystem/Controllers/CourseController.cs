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
    [Route("/Course")]
    public class CourseController : Controller
    {
        // GET: /course
        [HttpGet]
        public IActionResult GetCourses()
        {
            List<Course> courses = new List<Course>
            {
                new Course { Id = 1, Name = "OOAD", NumClass = 3, NumStudent = 60, StartTime = "1/9/2017", EndTime = "1/1/2018" },
                new Course { Id = 2, Name = "J2EE", NumClass = 1, NumStudent = 60, StartTime = "1/9/2017", EndTime = "1/1/2018" }
            };

            return Json(courses);
        }

        // POST: /course
        [HttpPost]
        public IActionResult PostCourse([FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Get information from json
            GradeProportion proportions = null;
            if (json.Proportions != null && json.Proportions.Report != "" && json.Proportions.Presentation != "" && json.Proportions.C != "" && json.Proportions.B != "" && json.Proportions.A != "")
            {
                proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            }
            Course newCourse = new Course { Name = json.Name, Description = json.Description, StartTime = json.StartTime, EndTime = json.EndTime, Proportions = proportions };

            // Store course information in server and generate a id for this new course
            newCourse.Id = 23;

            // Return course id
            string uri = "/course/" + newCourse.Id;
            return Created(uri, newCourse);
        }

        // GET: /course/{courseId}
        [HttpGet("{courseId}")]
        public IActionResult GetCourseByCourseId(int courseId)
        {
            // Fetch data from database
            CourseDetail course = new CourseDetail { Id = 1, Name = "OOAD", Description = "面向对象分析与设计", StartTime = "1/9/2017", EndTime = "1/1/2018", TeacherName = "邱明", TeacherEmail = "mingqiu@xmu.edu.cn" };

            //If not found
            if (course == null)
                return NotFound();

            return Json(course);
        }

        // PUT: /course/{courseId}
        [HttpPut("{courseId}")]
        public IActionResult PutCourseByCourseId(int courseId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //return Forbid();

            //Get information from json
            GradeProportion proportions = null;
            if (json.Proportions != null && json.Proportions.Report != "" && json.Proportions.Presentation != "" && json.Proportions.C != "" && json.Proportions.B != "" && json.Proportions.A != "")
            {
                proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            }
            Course editedCourse = new Course { Name = json.Name, Description = json.Description, StartTime = json.StartTime, EndTime = json.EndTime, Proportions = proportions };

            //Change information in database

            //Success
            return NoContent();
        }

        // DELETE: /course/{courseId}
        [HttpDelete("{courseId}")]
        public IActionResult DeleteCourseByCourseId(int courseId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Delete course from database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // GET: /course/{courseId}/class
        [HttpGet("{courseId}/class")]
        public IActionResult GetClassList(int courseId)
        {
            // Fetch data from database
            List<Class> classes = new List<Class>
            {
                new Class { Id = 45, Name = "周三1-2节" },
                new Class { Id = 48, Name = "周三3-4节" }
            };

            // If not found
            if (classes == null)
                return NotFound();

            // Success
            return Json(classes);
        }

        // POST: /course/{courseId}/class
        [HttpPost("{courseId}/class")]
        public IActionResult PostNewClass(int courseId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //return Forbid();

            //Get information from json
            GradeProportion proportions = null;
            if (json.Proportions != null && json.Proportions.Report != "" && json.Proportions.Presentation != "" && json.Proportions.C != "" && json.Proportions.B != "" && json.Proportions.A != "")
            {
                proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            }
            Class newClass = new Class { Name = json.Name, Site = json.Site, Time = json.Time, Roster = json.Roster, Proportions = proportions };

            // Store class information in server and generate a id for this new class
            newClass.Id = 45;

            // Return class id
            string uri = "/class/" + newClass.Id;
            return Created(uri, newClass);
        }

        // GET: /course/{courseId}/seminar?embedGrade=false
        [HttpGet("{courseId}/seminar")]
        public IActionResult GetSeminarList(int courseId, [FromQuery]bool embedGrade = false)
        {
            //Authentication
            //When user's permission denied
            if(embedGrade != false)
                return BadRequest();

            // Fetch data from database
            List<Seminar> seminars = new List<Seminar>();
            if (embedGrade == false)
            {
                seminars.Add(new Seminar { Id = 45, Name = "界面原型设计", Description = "界面原型设计", GroupingMethod = "fixed", StartTime = "25/09/2017", EndTime = "09/10/2017" });
                seminars.Add(new Seminar { Id = 48, Name = "概要设计", Description = "模型层与数据库设计", GroupingMethod = "fixed", StartTime = "10/10/2017", EndTime = "24/10/2017" });
            }

            // If not found
            if (seminars == null)
                return NotFound();

            // Success
            return Json(seminars);
        }

        // POST: /course/{courseId}/seminar
        [HttpPost("{courseId}/seminar")]
        public IActionResult PostNewSeminar(int courseId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //return Forbid();

            //Get information from json
            GradeProportion proportions = null;
            if (json.Proportions != null && json.Proportions.Report != "" && json.Proportions.Presentation != "" && json.Proportions.C != "" && json.Proportions.B != "" && json.Proportions.A != "")
            {
                proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            }
            Seminar newSeminar = new Seminar { Name = json.Name, Description = json.Description, GroupingMethod = json.GroupingMethod, StartTime = json.StartTime, EndTime = json.EndTime, Proportions = proportions };

            // Store seminar information in server and generate a id for this new seminar
            newSeminar.Id = 32;

            // Return seminar id
            string uri = "/seminar/" + newSeminar.Id;
            return Created(uri, newSeminar);
        }

        // GET: /course/{courseId}/grade
        [HttpGet("{courseId}/grade")]
        public IActionResult GetStudentGradeUnderAllSeminar(int courseId)
        {
            // Fetch data from database
            List<SeminarGradeDetail> seminarGrades = new List<SeminarGradeDetail>
            {
                new SeminarGradeDetail { SeminarName = "需求分析", GroupName = "3A2", LeaderName = "张三", PresentationGrade = 4, ReportGrade = 4, Grade = 4 },
                new SeminarGradeDetail { SeminarName = "界面原型设计", GroupName = "3A3", LeaderName = "张三", PresentationGrade = 5, ReportGrade = 5, Grade = 5 }
            };

            // If not found
            if (seminarGrades == null)
                return NotFound();

            // Success
            return Json(seminarGrades);
        }

    }
}
