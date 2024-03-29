using Ecommmerce.Application.DTO.Entities.Product;
using Ecommmerce.Application.Features.Product.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Features.Product.Handelers.Queries
{
    public class GetProductDetailsHandeler:IRequestHandler<GetProductDetailsRequset,ProductDTO>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductDetailsHandeler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository=productRepository;
            this.mapper=mapper;
        }

        public async Task<ProductDTO> Handle(GetProductDetailsRequset request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetAsync(request.Id);
            var response =mapper.Map<ProductDTO>(product);
            return response;
        }
    }
}
