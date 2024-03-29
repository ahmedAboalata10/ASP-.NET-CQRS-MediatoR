using Ecommmerce.Application.DTO.Entities.Category.Validators;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Features.Product.Requests.Commands;
using Ecommmerce.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Handelers.Commands
{
    public class UpdateCategoryHandeler : IRequestHandler<UpdateCategorytRequest, Unit>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public UpdateCategoryHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }

        public async Task<Unit> Handle(UpdateCategorytRequest request, CancellationToken cancellationToken)
        {
            var validator = new CategoryValidator();
            var validationResult = await validator.ValidateAsync(request.CategoryDTO);
            if (validationResult.IsValid == false)
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            var oldCategory = await categoryRepository.GetAsync(request.Id);
            var res = mapper.Map(request.CategoryDTO, oldCategory);
            await categoryRepository.UpdateAsync(request.Id, res);
            return Unit.Value;
        }
    }
}
