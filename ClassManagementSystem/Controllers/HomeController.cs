using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassManagementSystem.Models;

namespace ClassManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AccountLogin()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult CreateSchool()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
