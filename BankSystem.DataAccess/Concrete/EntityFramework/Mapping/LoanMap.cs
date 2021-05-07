using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework.Mapping
{
  public  class LoanMap:EntityTypeConfiguration<Loan>
    {
        public LoanMap()
        {
            ToTable("Loans");
            HasKey(l => l.Id);
            Property(l => l.Comission).HasColumnName("Comission");
            Property(l => l.InterestRate).HasColumnName("InterestRate");
            Property(l => l.LoanAmount).HasColumnName("LoanAmount");
            Property(l => l.LoanCurrency).HasColumnName("LoanCurrency");
            Property(l => l.LoanTerm).HasColumnName("LoanTerm");
            Property(l => l.LoanType).HasColumnName("LoanType");
            Property(l => l.MonthlyPayment).HasColumnName("MonthlyPayment");
            
        }
    }
}
