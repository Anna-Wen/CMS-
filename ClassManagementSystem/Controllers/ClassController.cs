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
            // Fetch selected class list from database
            List<CourseClass> classList = new List<CourseClass>
            {
                new CourseClass { Id = 23, Name = "周一1-2节", NumStudent = 60, Time = "周三1-2节、周五1-2节", Site = "学生公寓405", CourseId = 1, CourseName = "OOAD", CourseTeacher = new Teacher { Name = "邱明" } },
                new CourseClass { Id = 42, Name = ".NET一班", NumStudent = 60, Time = "周三3-4节、周四1-2节", Site = "海韵教学楼204", CourseId = 3, CourseName = ".Net 平台开发", CourseTeacher = new Teacher { Name = "杨律青" } }
            };
            if (courseName != null && courseName != "")
                classList = classList.FindAll((p) => p.CourseName.StartsWith(courseName));
            if (courseTeacher != null && courseTeacher != "")
                classList = classList.FindAll((p) => p.CourseTeacher.Name.StartsWith(courseTeacher));

            // If class not found
            if (classList == null)
                return NotFound();
            
            // Success
            return Json(classList);
        }

        // GET: /class/{classId}
        [HttpGet("{classId}")]
        public IActionResult GetClass(int classId)
        {
            // Fetch data from database
            GradeProportion proportions = new GradeProportion { Report = 50, Presentation = 50, C = 20, B = 60, A = 20 };
            Class selectedClass = new Class { Id = 23, Name = "周一1-2节", NumStudent = 60, Time = "周三1-2节、周五1-2节", Site = "学生公寓405", Calling = -1, Roster = "/roster/周一1-2班.xlsx", Proportions = proportions };

            //if class not found
            if (selectedClass == null)
                return NotFound();

            // Success
            return Json(selectedClass);
        }

        // PUT: /class/{classId}
        [HttpPut("{classId}")]
        public IActionResult PutClass(int classId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Get information from json
            GradeProportion proportions = new GradeProportion { Report = json.Proportions.Report, Presentation = json.Proportions.Presentation, C = json.Proportions.C, B = json.Proportions.B, A = json.Proportions.A };
            Class editedClass = new Class { Name = json.Name, Site = json.Site, Time = json.Time, Proportions = proportions };

            //Change information in database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // DELETE: /class/{classId}
        [HttpDelete("{classId}")]
        public IActionResult DeleteClass(int classId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Delete class from database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();
        }

        // GET: /class/{classId}/student?numBeginWith={numBeginWith}&nameBeginWith={nameBeginWith}
        [HttpGet("{classId}/student")]
        public IActionResult GetStudentListUnderClass(int classId, [FromQuery]string numBeginWith, [FromQuery]string nameBeginWith)
        {
            // Fetch selected class student list from database
            List<Student> studentList = new List<Student>
            {
                new Student { Id = 233, Name = "张三", Number = "24320152202333" },
                new Student { Id = 245, Name = "张八", Number = "24320152202334" },
                new Student { Id = 248, Name = "李四", Number = "24320152202345" },
                new Student { Id = 256, Name = "王五", Number = "24320152202356" }
            };
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
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();
            
            // Get information from json
            Student newStudentInClass = new Student { Id = int.Parse(json.Id) };

            // Judge and store class-student information in server
            
            // If already select another class under the same course
            //  return Conflict(); 

            // Return class id & student id
            string uri = "/class/" + classId + "/student/" + newStudentInClass.Id;
            return Created(uri, newStudentInClass);
        }

        // DELETE: /class/{classId}/student/{studentId}
        [HttpDelete("{classId}/student/{studentId}")]
        public IActionResult DeleteStudentUnderClass(int classId, int studentId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            //Delete student class relation from database
            //if not found
            //    return NotFound();

            //Success
            return NoContent();

        }

        // GET: /class/{classId}/classgroup
        [HttpGet("{classId}/classgroup")]
        public IActionResult GetClassGroup(int classId)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();

            // Fetch class group from database
            Student leader = new Student { Id = 233, Name = "张三", Number = "24320152202333" };
            Student s1 = new Student { Id = 248, Name = "李四", Number = "24320152202345" };
            Student s2 = new Student { Id = 256, Name = "王五", Number = "24320152202356" };
            List<Student> memberList = new List<Student>
            {
                s1,
                s2
            };

            ClassGroup classGroup = new ClassGroup { Leader = leader, Members = memberList};

            // Success
            return Json(classGroup);
        }

        // PUT: /class/{classId}/classgroup/add
        [HttpPut("{classId}/classgroup/add")]
        public IActionResult AddMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied (not in this group / not leader)
            //if(false)
            //  return Forbid();
            
            // Get information from json
            Student newStudentInClassGroup = new Student { Id = int.Parse(json.Id) };

            // Add student in classgroup database

            // If already in group
            //  return Conflict();

            // Success
            return NoContent(); 
        }

        // PUT: /class/{classId}/classgroup/remove
        [HttpPut("{classId}/classgroup/remove")]
        public IActionResult RemoveMemberIntoClassGroup(int classId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied (not in this group / not leader)
            //if(false)
            //  return Forbid();
            
            // Get information from json
            Student newStudentInClassGroup = new Student { Id = int.Parse(json.Id) };

            // Remove student from this classgroup database

            // If student is not in this group
            //  return Conflict();

            // Success
            return NoContent();         
        }
    }
}
