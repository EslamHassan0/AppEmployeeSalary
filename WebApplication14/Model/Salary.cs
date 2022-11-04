using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Model
{
    public class Salary
    {
        [Key]
        public int itemsalaryID { get; set; }
        public string itemSalary  { get; set; }

    }
}
