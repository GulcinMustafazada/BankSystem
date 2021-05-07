using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.Abstract
{
  public  interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer GetById(int id);
        List<Customer> GetAll();
        List<Customer> GetByFirstName(string FirstName);
        List<Customer> GetByLastName(string LastName);
        List<Customer>GetAddress(string Address);
        List<Customer> GetPhoneNumber(string PhoneNumber);
        List<Customer> GetCustomerCode(string CustomerCode);
        List<Customer> GetByAge(int min, int max);
        int GetMinAge();
        int GetMaxAge();
        List<Customer> GetByMoney(decimal min, decimal max);
        decimal GetMaxMoney();
        decimal GetMinMoney();
    }
}
