using Ecommmerce.Application.DTO.Entities.Product.Validators;
using Ecommmerce.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace Ecommmerce.Application.Features.Categories.Handelers.Commands
{
    public class CreateProductHandeler : IRequestHandler<CreateProductRequest, BaseCommandResponse>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public CreateProductHandeler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository=productRepository;
            this.mapper=mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new ProductValidator(productRepository);
            var validationResult = await validator.ValidateAsync(request.ProductDTO, cancellationToken);
            if (validationResult.IsValid == false)
            {
                response.Success=false;
                response.Message="Failed to Create Product";
                response.Errors=validationResult.Errors.Select(x=> x.ErrorMessage).ToList();
            }
            var product = mapper.Map<Ecommerce.Domain.Entities.Product>(request.ProductDTO);
            await productRepository.CreateAsync(product);
            response.Id=product.Id;
            response.Success = true;
            response.Message="Created successfully";
            return response;
        }
    }
}
