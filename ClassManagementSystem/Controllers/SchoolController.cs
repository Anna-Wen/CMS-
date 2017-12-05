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
    [Route("/school")]
    public class SchoolController : Controller
    {
        // GET: /school?city={city}
        [HttpGet]
        public IActionResult GetSchoolViaCity([FromQuery]string city)
        {
            return Ok();
        }
        
        // POST: /school
        [HttpPost]
        public IActionResult PostNewSchool([FromBody]string value)
        {
            return Ok();
        }

        // GET: /school/province
        [HttpGet("province")]
        public IActionResult GetProvince()
        {
            return Ok() ;
        }

        // GET: /school/city?province={province}
        [HttpGet("city")]
        public IActionResult GetCityViaProvince([FromQuery]string province)
        {
            return Ok();
        }

    }
}
