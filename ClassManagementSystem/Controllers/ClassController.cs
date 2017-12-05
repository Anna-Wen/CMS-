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
    [Route("/class")]
    public class ClassController : Controller
    {
        // GET: /class?courseName={courseName}&&courseTeacher={courseTeacher}
        [HttpGet]
        public IActionResult GetClassListFromQuery([FromQuery]string courseName, [FromQuery]string courseTeacher)
        {
            return Ok();
        }

        // GET: /class/{classId}
        [HttpGet("{classId}")]
        public IActionResult GetClass(int classId)
        {
            return Ok();
        }

        // PUT: /class/{classId}
        [HttpPut("{classId}")]
        public IActionResult PutClass(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /class/{classId}
        [HttpDelete("{classId}")]
        public IActionResult DeleteClass(int classId)
        {
            return Ok();
        }

        // GET: /class/{classId}/student
        [HttpGet("{classId}/student")]
        public IActionResult GetStudentListUnderClass(int classId)
        {
            return Ok();
        }

        // Post: /class/{classId}/student
        [HttpPost("{classId}/student")]
        public IActionResult PostStudentUnderClass(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /class/{classId}/student/{studentId}
        [HttpDelete("{classId}/student/{studentId}")]
        public IActionResult DeleteStudentUnderClass(int classId, int studentId)
        {
            return Ok();
        }

        // GET: /class/{classId}/classgroup
        [HttpGet("{classId}/classgroup")]
        public IActionResult GetClassGroup(int classId)
        {
            return Ok();
        }

        // PUT: /class/{classId}/classgroup/add
        [HttpPut("{classId}/classgroup/add")]
        public IActionResult AddMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // PUT: /class/{classId}/classgroup/remove
        [HttpPut("{classId}/classgroup/remove")]
        public IActionResult RemoveMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            return Ok();
        }

    }
}
