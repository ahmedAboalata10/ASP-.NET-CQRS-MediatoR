using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Handelers.Commands
{
    public class CreateCategoryHandeler : IRequestHandler<CreateCategoryRequest, Unit>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CreateCategoryHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }

        public async Task<Unit> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = mapper.Map<Category>(request.CategoryDTO);
            await categoryRepository.CreateAsync(category);
            return Unit.Value;
        }
    }
}
