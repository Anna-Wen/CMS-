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

        public IActionResult CheckTopicBeforeClass()
        {
            return View();
        }

        public IActionResult CheckTopicAfterClass()
        {
            return View();
        }

        public IActionResult CreateClass()
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

        // PUT: /{topicId}
        [HttpPut("{topicId}")]
        public IActionResult Put(int topicId)
        {
            return Json(new Topic { Id = 257, Name = "领域模型与模块", Description="Domain model与模块划分", GroupLimit=5, GroupLeft=3 });
        }

    }
}