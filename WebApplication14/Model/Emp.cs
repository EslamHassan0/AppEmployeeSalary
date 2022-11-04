using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Model
{

   
    public class Emp
    {
       
        [Key]
        public int idEmp { get; set; }
        public double salary { get; set; }
        public string fristname { get; set; }
        public string lastnema { get; set; }
        public string addres { get; set; }
        public int age { get; set; }
        public Department Department { get; set; }
     
        public ICollection<Employee_detail> employee_list { get; set; }

    }
}
