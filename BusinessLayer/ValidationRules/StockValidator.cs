using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(x => x.StockCode).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Bos gecilemez");
        }
    }
}
