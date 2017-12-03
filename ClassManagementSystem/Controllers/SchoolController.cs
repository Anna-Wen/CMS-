using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/School")]
    public class SchoolController : Controller
    {
        // GET: /School?city={city}
        [HttpGet]
        public IActionResult GetSchoolViaCity([FromQuery]string city)
        {
            return Ok();
        }
        
        // POST: /School
        [HttpPost]
        public IActionResult PostNewSchool([FromBody]string value)
        {
            return Ok();
        }

        // GET: /School/province
        [HttpGet("province")]
        public IActionResult GetProvince()
        {
            return Ok() ;
        }

        // GET: /School/city?province={province}
        [HttpGet("city")]
        public IActionResult GetCityViaProvince([FromQuery]string province)
        {
            return Ok();
        }

    }
}
