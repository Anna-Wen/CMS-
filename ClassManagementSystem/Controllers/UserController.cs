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

        //// GET: /me
        //[HttpGet("me")]
        //public IActionResult GetCurrentUser()
        //{
        //    //Fake Data
        //    School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
        //    User student = new User { Id = 123, Type = "student", Number = "24320152201234", Name = "张三", Phone = "18999999999", Email = "xxxxxx@163.com", Gender = "male", School = xmu, Title = "本科", UnionId = "", Avatar = "/images/user.png" };

        //    return Json(student);
        //}

        // GET: /me/teacher
        [HttpGet("me/teacher")]
        public IActionResult GetCurrentTeacher()
        {
            //Fake Data
            School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
            Teacher teacher = new Teacher { Id = 123, Number = "2432201234", Name = "邱明", Phone = "18999999999", Email = "mingqiu@xmu.edu.cn", Gender = "male", School = xmu, Title = "教授", UnionId = "", Avatar = "/images/123.png" };

            return Json(teacher);
        }

        // GET: /me/student
        [HttpGet("me/student")]
        public IActionResult GetCurrentStudent()
        {
            //Fake Data
            School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
            Student student = new Student { Id = 233, Number = "24320152201234", Name = "张三", Phone = "13600000000", Email = "xxxxxx@163.com", Gender = "male", School = xmu, Title = "本科", UnionId = "", Avatar = "/images/233.png" };

            return Json(student);
        }

        // PUT: /me
        [HttpPut("me")]
        public IActionResult Put(int id, [FromBody] dynamic json)
        {
            // Update this edited user info

            // Fetch info from database
            School xmu = new School { Id = 12, Name = "厦门大学", Province = "福建", City = "厦门" };
            User dataUser = new User { Id = 233, Type = "student", Number = "24320152201234", Name = "张三", Phone = "13600000000", Email = "xxxxxx@163.com", Gender = "male", School = xmu, Title = "本科", UnionId = "", Avatar = "/images/233.png" };

            if (dataUser == null)
                return BadRequest();
            else
            {
                dataUser.Type = json.Type;
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
        public IActionResult Signin([FromBody] dynamic json)
        {
            User curUser = new User
            {
                Phone = json.Phone,
                Password = json.Passsword
            };

            // Username & Password Autherization
            // 如果手机号/密码错误
            if (curUser == null)
                return Unauthorized();

            // Get user info from database
            curUser.Id = 3486;
            if (curUser.Phone == "18999999999")
                curUser.Type = "teacher";
            else
                curUser.Type = "student";

            // Create Token
            // Get key from configuration
            // Generate JWT
            string jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJjaWQiOiJPQTAwMDEiLCJpYXQiOjE0ODI2NTcyODQyMjF9.TeJpy936w610Vrrm+c3+RXouCA9k1AX0Bk8qURkYkdo=";
            // Set JWT into cookie
            // Set cookie

            return Ok(curUser);
            // 怎么传JWT？？？
        }

        // POST: /register
        [HttpPost("register")]
        public IActionResult Register([FromBody] dynamic json)
        {
            User curUser = new User
            {
                Phone = json.Phone,
                Password = json.Password
            };

            // Username & Password Autherization
            // 如果手机号已注册
            if (curUser == null)
                return Unauthorized();

            // Generate user info in database
            curUser.Id = 3486;
            curUser.Type = "unbinded";
            curUser.Name = "";

            // Create Token
            // Get key from configuration
            // Generate JWT
            string jwt = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJjaWQiOiJPQTAwMDEiLCJpYXQiOjE0ODI2NTcyODQyMjF9.TeJpy936w610Vrrm+c3+RXouCA9k1AX0Bk8qURkYkdo=";
            // Set JWT into cookie
            // Set cookie

            return Ok(curUser);
            // 怎么传JWT？？？
        }

    }
}
