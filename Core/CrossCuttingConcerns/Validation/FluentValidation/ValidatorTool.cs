using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator ,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if(!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
