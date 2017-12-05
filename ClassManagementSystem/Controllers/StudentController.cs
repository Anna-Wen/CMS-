using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult BasicInfo()
        {
            return View();
        }

        public IActionResult StudentCourseHome()
        {
            return View();
        }
        public IActionResult DiscussionClass()
        {
            return View();
        }
        public IActionResult CourseHome()
        {
            return View();
        }
        public IActionResult ViewTopic()
        {
            return View();
        }
        public IActionResult ViewGroup()
        {
            return View();
        }
        public IActionResult ChooseCourse()
        {
            return View();
        }
        public IActionResult ViewGrade()
        {
            return View();
        }
    }
}