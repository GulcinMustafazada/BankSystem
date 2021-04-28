using BankSystem.Entities.Concrete;
using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Abstract
{
   public interface ICustomerDal:IEntityRepository<Customer>
    {
        
    }
}
