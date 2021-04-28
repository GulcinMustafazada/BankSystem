using BankSystem.Business.Abstract;
using BankSystem.DataAccess.Abstract;
using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.Concrete
{
    class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(e => e.Id == id);
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
