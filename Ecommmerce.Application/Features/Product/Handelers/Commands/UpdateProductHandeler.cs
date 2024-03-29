using Ecommmerce.Application.DTO.Entities.Product.Validators;
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
    public class UpdateProductHandeler : IRequestHandler<UpdateProductRequest, Unit>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public UpdateProductHandeler(IProductRepository _productRepository, IMapper _mapper)
        {
            productRepository=_productRepository;
            mapper=_mapper;
        }

        public async Task<Unit> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            var validator = new ProductValidator(productRepository);
            var validationresult = await validator.ValidateAsync(request.ProductDTO, cancellationToken);
            if (validationresult.IsValid == false)
            {
                throw new Exceptions.ValidationException(validationresult);
            }
            var oldProduct = await productRepository.GetAsync(request.ProductDTO.Id);
            var res = mapper.Map(request.ProductDTO, oldProduct);
            await productRepository.UpdateAsync(request.ProductDTO.Id, res);
            return Unit.Value;
        }
    }
}
