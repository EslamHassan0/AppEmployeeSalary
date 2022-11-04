using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Model
{
    public class Department
    {
        [Key]
        public int Departmentid { get; set; }
        public string name { get; set; }
        public string Departmentaddres { get; set; }
        public int Quantity { get; set; }
        public ICollection<Emp> Employees { get; set; }





    }
}
