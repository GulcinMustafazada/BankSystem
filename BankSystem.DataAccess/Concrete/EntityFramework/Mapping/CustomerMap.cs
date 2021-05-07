using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework.Mapping
{
   public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");
            HasKey(c => c.Id);
            Property(c => c.Address).HasColumnName("Address");
            Property(c => c.Age).HasColumnName("Age");
            Property(c => c.CustomerCode).HasColumnName("CustomerCode");
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.LastName).HasColumnName("LastName");
            Property(c => c.Money).HasColumnName("Money");
            Property(c => c.PhoneNumber).HasColumnName("PhoneNumber");
        }

    }
}
