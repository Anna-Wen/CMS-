using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassManagementSystem.Models;

namespace ClassManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult CreateTopic()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult NewSeminar()
=======
        public IActionResult TeacherScoreHome()
>>>>>>> master
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult CheckTopicBeforeClass()
=======
        public IActionResult TeacherScoreReportPage()
>>>>>>> master
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult CheckTopicAfterClass()
=======
        public IActionResult BasicInfo()
>>>>>>> master
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult CreateClass()
=======
        public IActionResult TeacherCourseHome()
>>>>>>> master
        {
            return View();
        }
        
<<<<<<< HEAD
        public IActionResult CheckClassInfo()
        {
            return View();
        }

        public IActionResult CreateCourse()
        {
            return View();
        }

        public IActionResult Bind()
        {
            return View();
        }

        public IActionResult CreateSchool()
        {
            return View();
        }

        // PUT: /{topicId}
        [HttpPut("{topicId}")]
        public IActionResult Put(int topicId)
        {
            return Json(new Topic { Id = 257, Name = "领域模型与模块", Description="Domain model与模块划分", GroupLimit=5, GroupLeft=3 });
        }

=======
            public IActionResult CheckClassInfo()
        {
            return View(); 
        }
        public IActionResult CheckSeminar()
        {
            return View();
        }
>>>>>>> master
    }
}