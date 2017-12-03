using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/Course")]
    public class CourseController : Controller
    {
        // GET: /Course
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok();
        }

        // POST: /Course
        [HttpPost]
        public IActionResult PostCourse([FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /Course/{courseId}
        [HttpGet("{courseId}")]
        public IActionResult GetCourseByCourseId(int courseId)
        {
            return Ok();
        }

        // PUT: /Course/{courseId}
        [HttpPut("{courseId}")]
        public IActionResult PutCourseByCourseId(int courseId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /Course/{courseId}
        [HttpDelete("{courseId}")]
        public IActionResult DeleteCourseByCourseId(int courseId)
        {
            return Ok();
        }

        // GET: /Course/{courseId}/class
        [HttpGet("{courseId}/class")]
        public IActionResult GetClassList(int courseId)
        {
            return Ok();
        }

        // POST: /Course/{courseId}/class
        [HttpPost("{courseId}/class")]
        public IActionResult PostNewClass(int courseId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /Course/{courseId}/seminar
        [HttpGet("{courseId}/seminar")]
        public IActionResult GetSeminarList(int courseId)
        {
            return Ok();
        }

        // POST: /Course/{courseId}/seminar
        [HttpPost("{courseId}/seminar")]
        public IActionResult PostNewSeminar(int courseId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /Course/{courseId}/grade
        [HttpGet("{courseId}/grade")]
        public IActionResult GetStudentGradeUnderAllSeminar(int courseId)
        {
            return Ok();
        }

    }
}
