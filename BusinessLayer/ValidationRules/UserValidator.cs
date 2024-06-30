using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x =>x.UserName).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x =>x.UserPassword).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x =>x.UserEmail).NotEmpty().WithMessage("Bos gecilemez");
        }
    }
}
