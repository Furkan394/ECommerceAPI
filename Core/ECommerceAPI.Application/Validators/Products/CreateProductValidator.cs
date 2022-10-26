using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the product name.")
                .MinimumLength(3)
                .MaximumLength(150)
                    .WithMessage("Please enter the product name between 3 and 150 characters.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the stock information.")
                .Must(s => s >= 0)
                    .WithMessage("Stock information cannot be negative.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the price information.")
                .Must(p => p >= 0)
                    .WithMessage("Price information cannot be negative.");
        }
    }
}
