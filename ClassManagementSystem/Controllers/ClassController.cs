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
        // GET: /class?courseName={courseName}&courseTeacher={courseTeacher}
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

        // GET: /class/{classId}/student?numBeginWith={numBeginWith}&nameBeginWith={nameBeginWith}
        [HttpGet("{classId}/student")]
        public IActionResult GetStudentListUnderClass(int classId, [FromQuery]string numBeginWith, [FromQuery]string nameBeginWith)
        {
            // Fetch selected class student list from database
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student { Id = 233, Name = "张三", Number = "24320152202333" });
            studentList.Add(new Student { Id = 245, Name = "张八", Number = "24320152202334" });
            studentList.Add(new Student { Id = 248, Name = "李四", Number = "24320152202345" });
            studentList.Add(new Student { Id = 256, Name = "王五", Number = "24320152202356" });
            if (numBeginWith != null && numBeginWith != "")
                studentList = studentList.FindAll((p) => p.Number.StartsWith(numBeginWith));
            if (nameBeginWith != null && nameBeginWith != "")
                studentList = studentList.FindAll((p) => p.Name.StartsWith(nameBeginWith));

            // If class not found
            if (studentList == null)
                return NotFound();
            
            // Success
            return Json(studentList);
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
            //Authentication
            //When user's permission denied
            //if(false)
            //return Forbid();

            // Fetch class group from database
            Student leader = new Student { Id = 233, Name = "张三", Number = "24320152202333" };
            Student s1 = new Student { Id = 248, Name = "李四", Number = "24320152202345" };
            Student s2 = new Student { Id = 256, Name = "王五", Number = "24320152202356" };
            List<Student> memberList = new List<Student>();
            memberList.Add(s1);
            memberList.Add(s2);

            ClassGroup classGroup = new ClassGroup { Leader = leader, Members = memberList};

            // Success
            return Json(classGroup);
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
