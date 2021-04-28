using BankSystem.DataAccess.Abstract;
using BankSystem.DataAccess.Concrete.EntityFramework;
using BankSystem.Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete
{
   public class EfLoanDal:EfEntityRepositoryBase<Loan ,BankContext>,ILoanDal
    {
    }
}
