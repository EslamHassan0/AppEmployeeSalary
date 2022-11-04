using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;
using WebApplication14.ViewModels;

namespace WebApplication14.Service
{
  public  interface ISalaryService
    {
        List<Salary> GetsalaryList();
        Salary GetSalaryDetailsById(int SId);
        ResponseModel Savesalary(Salary SalaryModel);
      
        ResponseModel DeleteSalary(int Salaryid);
    }
}
