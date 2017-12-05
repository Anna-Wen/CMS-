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
<<<<<<< HEAD

        public IActionResult TeacherScoreHome()
        {
            return View();
        }

        public IActionResult TeacherScoreReportPage()
        {
            return View();
        }

        public IActionResult BasicInfo()
=======
        public IActionResult TeacherCourseHome()
        {
            return View();
        }
        
            public IActionResult CheckClassInfo()
        {
            return View(); 
        }
        public IActionResult CheckSeminar()
>>>>>>> master
        {
            return View();
        }
    }
}