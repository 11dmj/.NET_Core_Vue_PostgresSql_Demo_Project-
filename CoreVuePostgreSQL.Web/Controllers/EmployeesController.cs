using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVuePostgreSQL.Data.Models;
using CoreVuePostgreSQL.Service;
using CoreVuePostgreSQL.Web.RequestModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreVuePostgreSQL.Web.Controllers
{
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class EmployeesController : ControllerBase
    {
        
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeeService _emp;

        public EmployeesController(ILogger<EmployeesController> logger,IEmployeeService emp)
        {
            _logger = logger;
            _emp = emp;
        }

        [HttpGet("api/employees")]
        public IActionResult GetAllEmployees()
        {
            return Ok(_emp.GetEmployees());
        }

        [HttpPost("api/employees")]
        public IActionResult AddEmployee([FromBody] NewEmployee empModel)
        {
            var employee = new EmployeeModel
            {
                //EmployeeId = empModel.empId,
                FirstName = empModel.firstname,
                MiddleName = empModel.middlename,
                LastName = empModel.lastname,
                Password = empModel.psswd,
            };
            return Ok(_emp.AddNewEmployee(employee));
        }

        [HttpPut("api/employees/{id}")]
        public ActionResult UpdateEmployee()
        {
            return Ok("Successfully Updated!");
        }

        [HttpDelete("api/employees/{id}")]
        public ActionResult DeleteEmployee()
        {
            return Ok("Successfully Deleted!");
        }
    }
}
