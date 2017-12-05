using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult CreateTopic()
        {
            return View();
        }

        public IActionResult TeacherScoreHome()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult TeacherScoreReportPage()
=======
        public IActionResult CheckTopicBeforeClass()
        {
            return View();
        }
        public IActionResult TeacherScoreReport()
>>>>>>> master
        {
            return View();
        }

        public IActionResult BasicInfo()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult TeacherCourseHome()
=======
        public IActionResult CreateClass()
        {
            return View();
        }

        public IActionResult TeacherCourseInformation()
>>>>>>> master
        {
            return View();
        }
        
            public IActionResult CheckClassInfo()
        {
            return View(); 
        }

        public IActionResult CheckSeminar()
        {
            return View();
        }

        public IActionResult TeacherCourseHomePage()
        {
            return View();
        }
    }
}