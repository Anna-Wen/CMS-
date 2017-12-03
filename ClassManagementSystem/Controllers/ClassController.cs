using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/Class")]
    public class ClassController : Controller
    {
        // GET: /Class?courseName={courseName}&&courseTeacher={courseTeacher}
        [HttpGet]
        public IActionResult GetClassListFromQuery([FromQuery]string courseName, [FromQuery]string courseTeacher)
        {
            return Ok();
        }

        // GET: /Class/{classId}
        [HttpGet("{classId}")]
        public IActionResult GetClass(int classId)
        {
            return Ok();
        }

        // PUT: /Class/{classId}
        [HttpPut("{classId}")]
        public IActionResult PutClass(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /Class/{classId}
        [HttpDelete("{classId}")]
        public IActionResult DeleteClass(int classId)
        {
            return Ok();
        }

        // GET: /Class/{classId}/student
        [HttpGet("{classId}/student")]
        public IActionResult GetStudentListUnderClass(int classId)
        {
            return Ok();
        }

        // Post: /Class/{classId}/student
        [HttpPost("{classId}/student")]
        public IActionResult PostStudentUnderClass(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /Class/{classId}/student/{studentId}
        [HttpDelete("{classId}/student/{studentId}")]
        public IActionResult DeleteStudentUnderClass(int classId, int studentId)
        {
            return Ok();
        }

        // GET: /Class/{classId}/classgroup
        [HttpGet("{classId}/classgroup")]
        public IActionResult GetClassGroup(int classId)
        {
            return Ok();
        }

        // PUT: /Class/{classId}/classgroup/add
        [HttpPut("{classId}/classgroup/add")]
        public IActionResult AddMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // PUT: /Class/{classId}/classgroup/remove
        [HttpPut("{classId}/classgroup/remove")]
        public IActionResult RemoveMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

    }
}
