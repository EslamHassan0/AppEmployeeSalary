using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Service;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestEmployeeController : ControllerBase
    {

        IEmployeeService _employeeService;
        public TestEmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }
        [HttpGet]
        [Route("[GetEmployeesdata]")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployeesList();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }





    }
}
