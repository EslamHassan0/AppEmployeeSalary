using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Model;
using WebApplication14.Model;
using WebApplication14.ViewModels;

namespace WebApplication14.Service
{
    public class SalaryService : ISalaryService
    {
        private AbbDbcontext _context;
        public SalaryService(AbbDbcontext context)
        {
            _context = context;
        }
        public List<Salary> GetsalaryList()
        {
            List<Salary> SalaryList;
            try
            {
                SalaryList = _context.Set<Salary>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return SalaryList;
        }
        public Salary GetSalaryDetailsById(int Sid)
        {
            Salary salary1;
            try
            {
                salary1 = _context.Find<Salary>(Sid);
            }
            catch (Exception)
            {
                throw;
            }
            return salary1;
        }
        public ResponseModel Savesalary(Salary salaryModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Salary _op = GetSalaryDetailsById(salaryModel.itemsalaryID);
                if (_op != null)
                {
                  
                    _op.itemSalary = salaryModel.itemSalary;
                   
                    model.Messsage = "Salary Update Successfully";
                }
                else
                {
                    _context.Add<Salary>(salaryModel);
                    model.Messsage = "Salary Inserted Successfully";
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

        private Salary GetSalaryDetailsById(object salaryId)
        {
            throw new NotImplementedException();
        }
        public ResponseModel DeleteSalary(int SalaryId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Salary _op = GetSalaryDetailsById(SalaryId);
                if (_op != null)
                {
                    _context.Remove<Salary>(_op);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Salary Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Salary Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

    }
}
