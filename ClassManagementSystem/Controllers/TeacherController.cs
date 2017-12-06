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

        public IActionResult NewSeminar()
        {
            return View();
        }

        public IActionResult TeacherScoreHome()
        {
            return View();
        }

        public IActionResult CheckTopicBeforeClass()
        {
            return View();
        }
        public IActionResult TeacherScoreReport()
        {
            return View();
        }

        public IActionResult CheckTopicAfterClass()
        {
            return View();
        }
        public IActionResult BasicInfo()
        {
            return View();
        }

        public IActionResult CreateClass()
        {
            return View();
        }

        public IActionResult TeacherCourseInformation()
        {
            return View();
        }
        
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

       
        public IActionResult CheckSeminar()
        {
            return View();
        }
        public IActionResult CheckTopic()
        {
            return View();
        }

        public IActionResult CreateSeminar()
        {
            return View();
        }
    }
}