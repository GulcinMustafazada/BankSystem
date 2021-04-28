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
    public class LoanManager : ILoanService
    {
        private ILoanDal _loanDal;
        public LoanManager(ILoanDal loanDal)
        {
            _loanDal = loanDal;
        }
        public void Add(Loan loan)
        {
            _loanDal.Add(loan);
        }

        public void Delete(Loan loan)
        {
          _loanDal.Delete(loan);
        }

        public List<Loan> GetAll()
        {
            return _loanDal.GetAll();
        }

        public Loan GetById(int id)
        {
          return _loanDal.Get(l=>l.Id==id);
        }

        public void Update(Loan loan)
        {
            _loanDal.Update(loan);
        }
    }
}
