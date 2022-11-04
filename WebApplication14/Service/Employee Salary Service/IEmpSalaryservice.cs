using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;
using WebApplication14.Service;
using WebApplication14.ViewModels;

namespace WebApplication14.Service2
{
   public interface IEmpSalaryservice
    {
        List<EmpSalary> GetEmployeesSalaryList();
       EmpSalary GetEmployeeSalaryDetailsById(int empId);
       ResponseModel SaveEmpSalary(EmpSalary employeeSalaryModel);
        ResponseModel SaveEmployeeSalary(Salarymanaglist employeeSalaryModel);
        ResponseModel DeleteEmpSalary(int employeeSalaryId);

    }
}
