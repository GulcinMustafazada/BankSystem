using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework.Mapping
{
   public class DirectorMap:EntityTypeConfiguration<Director>
    {
        public DirectorMap()
        {
            ToTable("Directors");
            HasKey(d => d.Id);
            Property(d => d.Age).HasColumnName("Age");
            Property(d => d.FirstName).HasColumnName("FirstName");
            Property(d => d.LastName).HasColumnName("LastName");
            Property(d => d.PhoneNumber).HasColumnName("PhoneNumber");
            Property(d => d.Position).HasColumnName("Position");
            Property(d => d.Salary).HasColumnName("Salary");

               
        }
    }
}
