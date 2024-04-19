using Ecommmerce.Application.DTO.Entities.Category.Validators;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Persistance.Contracts;
using Ecommmerce.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Handelers.Commands
{
    public class CreateCategoryHandeler : IRequestHandler<CreateCategoryRequest, BaseCommandResponse>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CreateCategoryHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CategoryValidator();
            var validationResult = await validator.ValidateAsync(request.CategoryDTO);
            if (validationResult.IsValid == false)
            {
                response.Success =false;
                response.Message ="Failed to Create New Category";
                response.Errors=validationResult.Errors.Select(x=> x.ErrorMessage).ToList();
            }
            var category = mapper.Map<Category>(request.CategoryDTO);
            await categoryRepository.CreateAsync(category);
            response .Success= true;
            response.Message="Successfully Created";
            response.Id = category.Id;
            return response;
        }
    }
}
