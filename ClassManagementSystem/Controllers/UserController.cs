﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassManagementSystem.Models;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class UserController : Controller
    {
        List<User> users = new List<User>();

        // GET: /me
        [HttpGet("/me")]
        public IActionResult GetCurrentUser()
        {
            return Json(users);
        }

        // PUT: /me
        [HttpPut("/me")]
        public void Put(int id, [FromBody] User editedUser)
        {
            
        }

        // POST: /signin
        [HttpPost("/signin")]
        public void Signin([FromBody] User value)
        {

        }

        // POST: /register
        [HttpPost("/register")]
        public void Register([FromBody] User value)
        {
            
        }

    }
}
