using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Model
{
    public class Employee_detail
    {
        [Key]
        public int Employeedetailid { get; set; }
        public string job { get; set; }
        public double salary { get; set; }
        public string skills { get; set; }
      
        public Emp Empid { get; set; }
       

        public Jop Jopid { get; set; }
        

    }
}
