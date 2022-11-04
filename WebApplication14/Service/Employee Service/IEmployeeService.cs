using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Model;

namespace WebApplication14.Service
{
  public interface IEmployeeService
    {

        List<Emp> GetEmployeesList();

    }
}
