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
    }
}