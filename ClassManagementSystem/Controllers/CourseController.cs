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
    [Route("/course")]
    public class CourseController : Controller
    {
        // GET: /course
        [HttpGet]
        public IActionResult GetCourses()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course { Id = 1, Name = "OOAD", NumClass = 3, NumStudent = 60, StartTime = "1/9/2017", EndTime = "1/1/2018" });
            courses.Add(new Course { Id = 2, Name = "J2EE", NumClass = 1, NumStudent = 60, StartTime = "1/9/2017", EndTime = "1/1/2018" });

            return Json(courses);
        }

        // POST: /course
        [HttpPost]
        public IActionResult PostCourse([FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
                //return Forbid();

            //Get information from json
            GradeProportion proportions =  new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            Course newCourse = new Course { Name = json.Name, Description = json.Description, StartTime = json.StartTime, EndTime = json.EndTime, Proportions = proportions };

            // Store course information in server and generate a id for this new course
            newCourse.Id = 23;

            // Return course id
            return Created("/Course/" + newCourse.Id, newCourse);
        }

        // GET: /course/{courseId}
        [HttpGet("{courseId}")]
        public IActionResult GetCourseByCourseId(int courseId)
        {
            // Fetch data from database
            CourseDetail course = new CourseDetail { Id = 1, Name = "OOAD", Description = "面向对象分析与设计", TeacherName = "邱明", TeacherEmail = "mingqiu@xmu.edu.cn" };

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
            GradeProportion proportions =  new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
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
            List<Class> classes = new List<Class>();
            classes.Add(new Class { Id = 45, Name = "周三1-2节" });
            classes.Add(new Class { Id = 48, Name = "周三3-4节" });

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
            GradeProportion proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            Class newClass = new Class { Name = json.Name, Site = json.Site, Time = json.Time, Proportions = proportions };

            // Store course information in server and generate a id for this new course
            newClass.Id = 45;

            // Return course id
            return Created("/Class/" + newClass.Id, newClass);
        }

        // GET: /course/{courseId}/seminar
        [HttpGet("{courseId}/seminar")]
        public IActionResult GetSeminarList(int courseId)
        {
            return Ok();
        }

        // POST: /course/{courseId}/seminar
        [HttpPost("{courseId}/seminar")]
        public IActionResult PostNewSeminar(int courseId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /course/{courseId}/grade
        [HttpGet("{courseId}/grade")]
        public IActionResult GetStudentGradeUnderAllSeminar(int courseId)
        {
            return Ok();
        }

    }
}
