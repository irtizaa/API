using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetTest()
        {
            var list = new List<string> { "testing", "1" };
            return Ok(list);
        }
    }
}
