using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.Abstract
{
   public interface IEmployeeService
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        Employee GetById(int id);
        List<Employee> GetAll();
    }
}
