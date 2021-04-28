using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Entities.Concrete
{
  public  class Employee:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber{ get; set; }
        public string Position { get; set; }
        public string EmployeeEducation { get; set; }
    }
}
