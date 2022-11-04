using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Model;

namespace WebApplication14.Model
{
    public class EmpSalary
    {
        [Key]
        public int EmpSalaryId { get; set; }
        public double Values { get; set; }
        public DateTime Date { get; set; }
        public Emp emploes { get; set; }
        public Salary  Salary { get; set; }


    }
}
