using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Model;
using WebApplication14.Model;
using WebApplication14.Service;
using WebApplication14.Service2;
using WebApplication14.ViewModels;

namespace WebApplication14.Service
{
    public class EmpSalaryService : IEmpSalaryservice
    {
        private AbbDbcontext _context;
        public EmpSalaryService(AbbDbcontext context)
        {
            _context = context;
        }
        public List<EmpSalary> GetEmployeesSalaryList()
        {
            List<EmpSalary> empSalaryList;
            try
            {
                empSalaryList = _context.Set<EmpSalary>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empSalaryList;
        }
        public EmpSalary GetEmployeeSalaryDetailsById(int empSalaryId)
        {
            EmpSalary empSalary;
            try
            {
                empSalary = _context.Find<EmpSalary>(empSalaryId);
            }
            catch (Exception)
            {
                throw;
            }
            return empSalary;
        }
        public ResponseModel SaveEmployee(EmpSalary employeeSalaryModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EmpSalary _empSalary = new EmpSalary();// GetEmployeeSalaryDetailsById(employeeSalaryModel.EmpSalaryId);
                if (_empSalary != null)
                {
                    _empSalary.Values = employeeSalaryModel.Values;
                    _empSalary.Date = employeeSalaryModel.Date;
                    _empSalary.emploes = employeeSalaryModel.emploes;
                    _empSalary.Salary = employeeSalaryModel.Salary;
                    _context.Add<EmpSalary>(_empSalary);
                    model.Messsage = "EmployeeSalary add Successfully";
                }
                else
                {
                    _context.Add<EmpSalary>(employeeSalaryModel);
                    model.Messsage = "EmployeeSalary Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel SaveEmployeeSalary(Salarymanaglist employeeSalaryModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                foreach (var item in employeeSalaryModel.Empsalarylist)

                {
                    EmpSalary _Emp = new EmpSalary();
                    _Emp.emploes = item.emploes;
                    _Emp.EmpSalaryId = item.EmpSalaryId;
                    _Emp.Values = item.Values;
                    _Emp.Date = item.Date;

                    _context.Add<EmpSalary>(_Emp);
                    model.Messsage = "EmployeeSalary add Successfully";
                }
                try
                {
                    _context.SaveChanges();
                    model.Messsage = "EmployeeSalary add Successfully";
                    model.IsSuccess = true;
                }
                catch(Exception Ex)
                {
                    model.Messsage = "Employee failed ";
                    model.IsSuccess = false;
                   
                }




            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel DeleteEmployeeSalary(int employeeSalaryId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EmpSalary _empSalary = GetEmployeeSalaryDetailsById(employeeSalaryId);
                if (_empSalary != null)
                {
                    _context.Remove<EmpSalary>(_empSalary);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "EmployeeSalary Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "EmployeeSalary Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel SaveEmpSalary(EmpSalary employeeSalaryModel)
        {
            throw new NotImplementedException();
        }

        public ResponseModel DeleteEmpSalary(int employeeSalaryId)
        {
            throw new NotImplementedException();
        }
    }
   public class Salarymanaglist
    {
        public int EmployeeID { get; set; }
        public List<EmpSalary> Empsalarylist;
    }
}
