using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.DTO.Entities.Product;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Features.Categories.Requests.Queries;
using Ecommmerce.Application.Features.Product.Requests.Commands;
using Ecommmerce.Application.Features.Product.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator=mediator;
        }
        [HttpGet("get-all-products")]
        public async Task<IActionResult> GetAll()
        {
            var products = await mediator.Send(new GetAllProductsRequset());
            return Ok(products);
        }
        [HttpGet("get-product-byid/{id}")]
        public async Task<IActionResult> GetProductbyId(int id)
        {
            var product = await mediator.Send(new GetProductDetailsRequset { Id=id });
            return Ok(product);
        }
        [HttpPost("create-new-product")]
        public async Task<IActionResult> CreateNewProduct(ProductDTO product)
        {
            var command = new CreateProductRequest { ProductDTO = product };
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpPut("update-product")]
        public async Task<IActionResult> UpdateProduct([FromBody]  ProductDTO product)
        {
            var command = new UpdateProductRequest {ProductDTO=product };
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpDelete("delete-category-byId")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductReuest { Id = id };
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}
