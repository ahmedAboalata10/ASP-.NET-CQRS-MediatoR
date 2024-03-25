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
    public class UpdateCategoryHandeler : IRequestHandler<UpdateCategoryRequest, Unit>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public UpdateCategoryHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }

        public async Task<Unit> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
        {
            var oldCategory = await categoryRepository.GetAsync(request.Id);
            var res = mapper.Map(request.Category, oldCategory);
            await categoryRepository.UpdateAsync(request.Id, res);
            return Unit.Value;
        }
    }
}
