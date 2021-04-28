using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Entities.Concrete
{
   public class Loan:IEntity
    {
        public int Id { get; set; }
        public string LoanType { get; set; }
        public string LoanCurrency { get; set; }
        public string LoanTerm { get; set; }
        public int Comission{ get; set; }
        public int InterestRate { get; set; }
        public decimal LoanAmount{ get; set; }
        public decimal MonthlyPayment { get; set; }
    }
}
