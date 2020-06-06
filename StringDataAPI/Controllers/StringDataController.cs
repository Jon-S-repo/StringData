using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace StringDataAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringDataController : ControllerBase
    {
        [HttpGet("{inputString}")]
        public ActionResult Get(string inputString)
        {
            if(!string.IsNullOrEmpty(inputString) && Regex.IsMatch(inputString, "^[a-zA-Z]*$"))
            {
                StringData returnObject = new StringData(inputString);
                return Ok(returnObject);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Invalid Input");
            }
        }
    }
}
