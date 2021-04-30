using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess.Concrete.EntityFramework
{
   public class BankContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }
}
