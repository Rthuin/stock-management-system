﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Bos gecilemez");
      
        }
    }
}
