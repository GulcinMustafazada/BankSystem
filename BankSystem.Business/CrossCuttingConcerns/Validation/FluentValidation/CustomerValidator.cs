using BankSystem.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.CrossCuttingConcerns.Validation.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().Must(IsStartWith).WithMessage(" Firstname must be start with upper case letter!");
            RuleFor(c => c.FirstName).Must(NotStartWith).WithMessage("Firstname must not start with the letters 'Ğ' and 'I' ");
            RuleFor(c => c.LastName).NotEmpty().Must(IsStartWith).WithMessage("Lastname must be start with upper case letter!");
            RuleFor(c => c.LastName).Must(NotStartWith).WithMessage("Lastname must not start with the letters 'Ğ' and 'I' ");
            RuleFor(c => c.Address).NotEmpty().MinimumLength(2);
            RuleFor(c => c.Age).NotEmpty().GreaterThanOrEqualTo(18).LessThanOrEqualTo(65).WithMessage("Age must be between 18 and 65");
            RuleFor(c => c.CustomerCode).NotEmpty().CreditCard();
            RuleFor(c => c.Money).NotEmpty().GreaterThan(0).WithMessage("Money can not be less than 0");
            RuleFor(c => c.PhoneNumber).NotEmpty().MinimumLength(5);

        }
        private bool IsStartWith(string name)
        {
            if (name[0].ToString() == name[0].ToString().ToUpper()) return true;
            return false;
            
        }
        private bool NotStartWith(string name1)
        {
           return !(name1.StartsWith("Ğ") | name1.StartsWith("I")) ;
           
        }
    }
}
