using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.Features.Categories.Requests.Queries;
using Ecommmerce.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Categories.Handelers.Queries
{
    public class GetCatagoryDetailsHandeler : IRequestHandler<GetCategoryDetailsRequest, CategoryDTO>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public GetCatagoryDetailsHandeler(ICategoryRepository categoryRepository,IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }
        public async Task<CategoryDTO> Handle(GetCategoryDetailsRequest request, CancellationToken cancellationToken)
        {
            var category=await categoryRepository.GetAsync(request.Id);
            if (category is null)
            {
                throw new Exception("Not Found Categoury");
            }
            return mapper.Map<CategoryDTO>(category);
        }
    }
}
