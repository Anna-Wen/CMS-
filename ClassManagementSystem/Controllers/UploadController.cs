using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/Upload")]
    public class UploadController : Controller
    {

        // POST: /Upload/avatar
        [HttpPost("avatar")]
        public IActionResult UploadAvatar([FromBody]dynamic json)
        {
            // Store file in server
            string file = json.File;
            // If encounter a problem
            if (file == null)
                return BadRequest();

            // Store avatar file url in user info
            string url = "/avatar/3486.png";

            // Return avatar file url
            return Created(url, file);
            // 该返回file吗？还是什么object？
        }

    }
}
