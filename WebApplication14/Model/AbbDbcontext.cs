using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Model;

namespace WebApplication10.Model
{
    public class AbbDbcontext:DbContext

    {
        public AbbDbcontext(DbContextOptions<AbbDbcontext> options) : base(options)
        {

        }
        public DbSet<Emp> Emps { get; set; }
        public DbSet <Department>Departments { get; set; }
        public DbSet <Employee_detail>employee_Details { get; set; }
        public DbSet <Jop>jops { get; set; }
        public DbSet<Salary> Salarys { get; set; }
        public DbSet <EmpSalary>empSalaries { get; set; }
    }
}
