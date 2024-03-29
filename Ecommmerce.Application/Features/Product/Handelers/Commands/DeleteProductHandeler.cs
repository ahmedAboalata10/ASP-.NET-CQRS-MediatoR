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
    public class DeleteProductHandeler:IRequestHandler<DeleteProductReuest, Unit>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public DeleteProductHandeler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository=productRepository;
            this.mapper=mapper;
        }

        public async Task<Unit> Handle(DeleteProductReuest request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetAsync(request.Id);
            if (product is null)
            {
                throw new Exceptions.NotFoundException(nameof(product), request.Id);
            }
            await productRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
