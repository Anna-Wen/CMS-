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
        public IActionResult PostNewSchool([FromBody]dynamic json)
        {
            // Get information from json
            School newSchool = new School { Name = json.Name, Province = json.Province, City = json.City };

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
            // Fetch province list from database
            List<string> provinceList = new List<string> { "北京", "天津", "上海", "重庆", "河北", "山西", "辽宁", "吉林", "黑龙江", "江苏", "浙江", "安徽", "福建", "江西", "山东", "河南", "湖北", "湖南", "广东", "海南", "四川", "贵州", "云南", "陕西", "甘肃", "青海", "台湾", "内蒙古自治区", "广西壮族自治区", "西藏自治区", "宁夏回族自治区", "新疆维吾尔自治区", "香港特别行政区", "澳门特别行政区" };

            // Success
            return Json(provinceList);
        }

        // GET: /school/city?province={province}
        [HttpGet("city")]
        public IActionResult GetCityViaProvince([FromQuery]string province)
        {
            // Fetch city list from database
            List<string> cityList = new List<string>();
            if (province == "北京")
                cityList.Add("北京");
            if (province == "广东")
            {
                cityList.Add("广州");
                cityList.Add("深圳");
                cityList.Add("珠海");
            }
            if (province == "福建")
            {
                cityList.Add("福州");
                cityList.Add("厦门");
                cityList.Add("漳州");
            }

            // If province not found
            if (cityList == null)
                return NotFound();

            // Success
            return Json(cityList);
        }

    }
}
