using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/Group")]
    public class GroupController : Controller
    {

        // GET: /Group/{groupId}
        [HttpGet("{groupId}")]
        public IActionResult GetGroupByGroupId(int groupId)
        {
            return Ok();
        }

        //下面的可以不用写

        //// PUT: /Group/{groupId}/add
        //[HttpPut("{groupId}/add")]
        //public IActionResult AddGroupMember(int groupId, [FromBody]dynamic json)
        //{
        //    return Ok();
        //}

        //// PUT: /Group/{groupId}/remove
        //[HttpPut("{groupId}/remove")]
        //public IActionResult RemoveGroupMember(int groupId, [FromBody]dynamic json)
        //{
        //    return Ok();
        //}

        // POST: /Group/{groupId}/topic
        [HttpPost("{groupId}/topic")]
        public IActionResult PostNewTopic(int groupId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // DELETE: /Group/{groupId}/topic/{topicId}
        [HttpPost("{groupId}/topic/{topicId}")]
        public IActionResult DeleteTopic(int groupId, int topicId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /Group/{groupId}/grade
        [HttpGet("{groupId}/grade")]
        public IActionResult GetGroupSeminarGrade(int groupId)
        {
            return Ok();
        }

        // PUT: /Group/{groupId}/grade/report
        [HttpGet("{groupId}/grade/report")]
        public IActionResult PutGroupReportGrade(int groupId, [FromBody]dynamic json)
        {
            return Ok();
        }

    }
}
