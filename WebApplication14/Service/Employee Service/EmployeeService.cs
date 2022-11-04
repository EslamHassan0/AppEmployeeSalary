using System;
using System.Collections.Generic;
using System.Linq; 
using WebApplication10.Model;
using System.Threading.Tasks;

namespace WebApplication14.Service
{
   
    public class EmployeeService:IEmployeeService
    {
        private AbbDbcontext _context;
        public EmployeeService(AbbDbcontext context)
        {
            _context = context;
        }
        public List<Emp> GetEmployeesList()
        {
            List<Emp> empList;
            try
            {
                empList = _context.Set<Emp>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }
    }
}
