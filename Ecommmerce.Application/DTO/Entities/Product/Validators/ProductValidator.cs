using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.DTO.Entities.Product.Validators
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        public ProductValidator(IProductRepository repository)
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty().WithMessage("{PropertyName} is required")
                .MinimumLength(3).WithMessage("{PropertyName} limit with {ComparisonValue} chars")
                .MaximumLength(50).WithMessage("{PropertyName} limit with {ComparisonValue} chars");
            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("{PropertyName} greater than  {ComparisonValue} ");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("{PropertyName} greater than  {ComparisonValue} ")
                .MustAsync(async (id, token) =>
                {
                    var categouryIsExisted = await repository.IsCategoryExist(id);
                    return categouryIsExisted;
                }).WithMessage("{PropertyName} does not exist ?");

        }
    }
}
