using BankSystem.Business.Abstract;
using BankSystem.Business.CrossCuttingConcerns.Validation.FluentValidation;
using BankSystem.DataAccess.Abstract;
using BankSystem.Entities.Concrete;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Transaction;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
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
        [ValidationAspect(typeof(CustomerValidator))]
        [TransactionAspect]
        public void Add(Customer customer)
        {
            ValidatorTool.FluentValidate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        [TransactionAspect]
        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetByFirstName(string FirstName)
        {
            return _customerDal.GetAll(c => c.FirstName.ToLower().Contains(FirstName.ToLower()));
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public Customer GetById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }
        [ValidationAspect(typeof(CustomerValidator))]
        [TransactionAspect]
        public void Update(Customer customer)
        {
            ValidatorTool.FluentValidate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetByLastName(string LastName)
        {
            return _customerDal.GetAll(c => c.LastName.ToLower().Contains(LastName.ToLower()));
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetAddress(string Address)
        {
            return _customerDal.GetAll(c => c.Address.ToUpper().Contains(Address.ToUpper()));
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetPhoneNumber(string PhoneNumber)
        {
            return _customerDal.GetAll(c => c.PhoneNumber.Contains(PhoneNumber));
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetCustomerCode(string CustomerCode)
        {
            return _customerDal.GetAll(c => c.CustomerCode.Contains(CustomerCode));
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetByAge(int min, int max)
        {
            return _customerDal.GetAll(c => c.Age >= min & c.Age <= max);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetMinAge()
        {
            return _customerDal.GetAll().Select(c => c.Age).Min();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetMaxAge()
        {
            return _customerDal.GetAll().Select(c => c.Age).Max();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetByMoney(decimal min, decimal max)
        {
            return _customerDal.GetAll(c => c.Money >= min & c.Money <= max);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public decimal GetMaxMoney()
        {
            return _customerDal.GetAll().Select(c => c.Money).Max();
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        public decimal GetMinMoney()
        {
            return _customerDal.GetAll().Select(c => c.Money).Min();
        }
    }
}
