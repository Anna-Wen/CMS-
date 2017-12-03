using System;
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
        
        // GET: /me
        [HttpGet("me")]
        public IActionResult GetCurrentUser()
        {
            //Fake Data
            School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
            User student = new User { Id = 123, Type = "student", Number = "24320152201234", Name = "张三", Phone = "18999999999", Email = "xxxxxx@163.com", Gender = "male", School = xmu, Title = "本科", UnionId = "", Avatar = "/images/user.png" };

            return Json(student);
        }

        // PUT: /me
        [HttpPut("me")]
        public IActionResult Put(int id, [FromBody] dynamic json)
        {
            // Update this edited user info

            // Fetch info from database
            School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
            User dataUser = new User { Id = 123, Type = "student", Number = "24320152201234", Name = "张三", Phone = "18999999999", Email = "xxxxxx@163.com", Gender = "male", School = xmu, Title = "本科", UnionId = "", Avatar = "/images/user.png" };

            if (dataUser == null)
                return BadRequest();
            else
            {
                dataUser.Name = json.Name;
                dataUser.Number = json.Number;
                dataUser.Gender = json.Gender;
                dataUser.Title = json.Title;
                dataUser.Avatar = json.Avatar;

                // Update database

                return NoContent();
            }
        }

        // POST: /signin
        [HttpPost("signin")]
        public void Signin([FromBody] User value)
        {

        }

        // POST: /register
        [HttpPost("register")]
        public void Register([FromBody] User value)
        {
            
        }

    }
}
