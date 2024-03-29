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
    public class DeleteCategoryHandeler : IRequestHandler<DeleteCategoryReuest, Unit>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public DeleteCategoryHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }

        public async Task<Unit> Handle(DeleteCategoryReuest request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.GetAsync(request.Id);
            if (category is null)
            {
                throw new Exceptions.NotFoundException(nameof(category), request.Id);
            }
            await categoryRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
