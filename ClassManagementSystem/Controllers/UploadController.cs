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
    [Route("/upload")]
    public class UploadController : Controller
    {

        // POST: /upload/avatar
        [HttpPost("avatar")]
        public IActionResult UploadAvatar([FromBody]dynamic json)
        {
            // Store file in server
            string file = json.File;
            // If encounter a problem (if pics's format is wrong)
            if (file == null)
                return BadRequest();

            // Store avatar file url in user info
            string uri = "/avatar/3486.png";

            // Return avatar file url
            return Created(uri, file);
            // 该返回file吗？还是什么object？
        }

    }
}
