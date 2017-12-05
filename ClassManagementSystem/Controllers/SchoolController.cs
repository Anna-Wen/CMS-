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
            // Fetch selected class list from database
            List<School> schoolList = new List<School>
            {
                new School { Id = 32, Name = "厦门大学", Province = "福建", City = "厦门" },
                new School { Id = 37, Name = "集美大学", Province = "福建", City = "厦门" },
                new School { Id = 45, Name = "中山大学", Province = "广东", City = "广州" },
                new School { Id = 56, Name = "北京大学", Province = "北京", City = "北京" }
            };
            if (city != null && city != "")
                schoolList = schoolList.FindAll((p) => p.City.StartsWith(city));

            // If school not found
            if (schoolList == null)
                return NotFound();
            
            // Success
            return Json(schoolList);
        }
        
        // POST: /school
        [HttpPost]
        public IActionResult PostNewSchool([FromBody]string value)
        {
            // Get information from json
            School newSchool = new School { Name = Json.Name, Province = Json.Province, City = Json.City };

            // Judge and store school information in server
            newSchool.Id = 38;
            
            // If already has a school with the same name
            //  return Conflict(); 

            // Return school id
            string uri = "/school/" + newSchool.Id;
            return Created(uri, newSchool);
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
