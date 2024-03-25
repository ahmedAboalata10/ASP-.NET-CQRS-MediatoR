using Ecommmerce.Application.DTO.Entities;
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
    public class GetAllCategoriesHandeler : IRequestHandler<GetAllCategoriesRequest, List<CategoryDTO>>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public GetAllCategoriesHandeler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository=categoryRepository;
            this.mapper=mapper;
        }
        public async Task<List<CategoryDTO>> Handle(GetAllCategoriesRequest request, CancellationToken cancellationToken)
        {
            //logic of get
            var categories = await categoryRepository.GetAllAsync();
            var response = mapper.Map<List<CategoryDTO>>(categories);
            return response;
        }
    }
}
