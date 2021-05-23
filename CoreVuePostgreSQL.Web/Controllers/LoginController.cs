using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreVuePostgreSQL.Web.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet("api/login/{id}")]
        public IActionResult GetEmployeeToken()
        {
            return Ok("Successfully Logged In!");
        }
        
        [HttpPost("api/login/{id}")]
        public ActionResult RegisterEmployee()
        {
            return Ok("Successfully Registered!");
        }
    }
}
