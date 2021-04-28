using BankSystem.DataAccess.Abstract;
using BankSystem.Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework
{
   public class EfCustomerDal :EfEntityRepositoryBase<Customer,BankContext>,ICustomerDal
    {
      
    }
}
