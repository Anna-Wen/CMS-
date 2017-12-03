using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult DiscussionClassPage_Fixed()
        {
            return View();
        }
    }
}