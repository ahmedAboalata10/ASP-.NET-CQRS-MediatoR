using Ecommmerce.Application.DTO.Entities.Product;
using Ecommmerce.Application.Features.Product.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Product.Handelers.Queries
{
    public class GetAllProductsHandeler : IRequestHandler<GetAllProductsRequset, List<ProductDTO>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetAllProductsHandeler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository=productRepository;
            this.mapper=mapper;
        }

        public async Task<List<ProductDTO>> Handle(GetAllProductsRequset request, CancellationToken cancellationToken)
        {
            var prododucts = await productRepository.GetAllAsync();
            var response = mapper.Map<List<ProductDTO>>(prododucts);
            return response;

        }
    }
}
