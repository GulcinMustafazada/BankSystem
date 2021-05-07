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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetByFirstName(string FirstName)
        {
            return _customerDal.GetAll(c => c.FirstName.ToLower().Contains(FirstName.ToLower()));
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public List<Customer> GetByLastName(string LastName)
        {
            return _customerDal.GetAll(c => c.LastName.ToLower().Contains(LastName.ToLower()));
        }

        public List<Customer> GetAddress(string Address)
        {
            return _customerDal.GetAll(c => c.Address.ToUpper().Contains(Address.ToUpper()));
        }

        public List<Customer> GetPhoneNumber(string PhoneNumber)
        {
            return _customerDal.GetAll(c => c.PhoneNumber.Contains(PhoneNumber));
        }

        public List<Customer> GetCustomerCode(string CustomerCode)
        {
            return _customerDal.GetAll(c => c.CustomerCode.Contains(CustomerCode));
        }
        public List<Customer> GetByAge(int min, int max)
        {
            return _customerDal.GetAll(c => c.Age >= min & c.Age <= max);
        }

        public int GetMinAge()
        {
            return _customerDal.GetAll().Select(c => c.Age).Min();
        }

        public int GetMaxAge()
        {
            return _customerDal.GetAll().Select(c => c.Age).Max();
        }

        public List<Customer> GetByMoney(decimal min, decimal max)
        {
            return _customerDal.GetAll(c => c.Money >= min & c.Money <= max);
        }

        public decimal GetMaxMoney()
        {
            return _customerDal.GetAll().Select(c => c.Money).Max();
        }

        public decimal GetMinMoney()
        {
            return _customerDal.GetAll().Select(c => c.Money).Min();
        }
    }
}
