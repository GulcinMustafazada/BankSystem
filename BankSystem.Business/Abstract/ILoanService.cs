using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.Abstract
{
   public interface ILoanService
    {
        void Add(Loan loan);
        void Update(Loan loan);
        void Delete(Loan loan);
        Loan GetById(int id);
        List<Loan> GetAll();
    }
}
