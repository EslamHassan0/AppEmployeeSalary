using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Model
{
    public class Jop
    {
        [Key]
        public int jobid { get; set; }
        public string Function { get; set; }
        public ICollection <Employee_detail>employee_Details { get; set; }
    }
}
