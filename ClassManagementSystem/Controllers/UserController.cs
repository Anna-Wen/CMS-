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
        User curUser = new User();

        // GET: /me
        [HttpGet("/me")]
        public IActionResult GetCurrentUser()
        {
            return Json(curUser);
        }

        // PUT: /me
        [HttpPut("/me")]
        public void Put(int id, [FromBody] User editedUser)
        {
            
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

    }
}
