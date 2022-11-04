using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;
using WebApplication14.Service;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        ISalaryService _SalaryService;
        public SalaryController(ISalaryService service)
        {
            _SalaryService = service;
        }

        [HttpGet]
        [Route("~/GetSalary")]
        public IActionResult GetAllSalary()
        {
            try
            {
                var salary = _SalaryService.GetsalaryList();
                if (salary == null) return NotFound();
                return Ok(salary);
            }
            catch (Exception)
            {
                return BadRequest();
            }



        }
        [HttpGet]
        [Route("~/getSalarybyid/{id:int}")]
        public IActionResult getSalarybyid(int id)
        {
            try
            {
                var salary = _SalaryService.GetSalaryDetailsById(id);
                if (salary == null) return NotFound();
                return Ok(salary);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("~/postSalary")]
        public IActionResult Savesalary( [FromBody] Salary SalaryModel)
        {
            try
            {
                var model = _SalaryService.Savesalary(SalaryModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpDelete]
        [Route("~/DeleteSalary/{id:int}")]
        public IActionResult DeleteSalary(int id)
        {
            try
            {
                var model = _SalaryService.DeleteSalary(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
