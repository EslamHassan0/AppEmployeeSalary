using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;
using WebApplication14.Service;
using WebApplication14.Service2;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpSalaryController : ControllerBase
    {
        IEmpSalaryservice _employeeSalaryService;
        public EmpSalaryController(IEmpSalaryservice service)
        {
            _employeeSalaryService = service;
        }
        [HttpGet]
        [Route("~/getEmpSalary")]
        public IActionResult GetAllEmployeesSalary()
        {
            try
            {
                var employeeSalary = _employeeSalaryService.GetEmployeesSalaryList();
                if (employeeSalary == null) return NotFound();
                return Ok(employeeSalary);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("~/getEmpSalarybyid/{id:int}")]
        public IActionResult GetEmployeesSalaryById(int id)
        {
            try
            {
                var employeesSalary = _employeeSalaryService.GetEmployeeSalaryDetailsById(id);
                if (employeesSalary == null) return NotFound();
                return Ok(employeesSalary
                    );
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("~/postEmpSalary")]
        public IActionResult SaveEmpsalary([FromBody] EmpSalary employeeSalaryModel)
        {
            try
            {
                var model = _employeeSalaryService.SaveEmpSalary(employeeSalaryModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpPost]
        [Route("~/Salarymanaglist")]
        public IActionResult SaveEmployeeSalary([FromBody] Salarymanaglist employeeSalaryModel)
        {
            try
            {
                var model = _employeeSalaryService.SaveEmployeeSalary(employeeSalaryModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }
            [HttpDelete]
        [Route("~/DeleteSalary/{id:int}")]
        public IActionResult DeleteEmployeeSalary(int id)
        {
            try
            {
                var model = _employeeSalaryService.DeleteEmpSalary(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }




    }
}
