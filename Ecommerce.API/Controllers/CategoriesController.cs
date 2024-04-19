using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Features.Categories.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {
            this.mediator=mediator;
        }
        [HttpGet("get-all-categouries")]
        public async Task<IActionResult> Get()
        {
            var categories = await mediator.Send(new GetAllCategoriesRequest());
            return Ok(categories);
        }
        [HttpGet("get-category-byid/{id}")]
        public async Task<IActionResult> GetCategorybyId(int id)
        {
            var category = await mediator.Send(new GetCategoryDetailsRequest { Id=id });
            return Ok(category);
        }
        [HttpPost("create-new-category")]
        public async Task<IActionResult> CreateNewCatgoory(CategoryDTO category)
        {
            var command = new CreateCategoryRequest { CategoryDTO = category };
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpPut("update-category")]
        public async Task<IActionResult> UpdateCategory([FromBody]  CategoryDTO category)
        {
            var command = new UpdateCategorytRequest { CategoryDTO =category };
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpDelete("delete-category-byId/{id}")]
        public async Task<IActionResult> DeleteCatagory(int id)
        {
            var command = new DeleteCategoryReuest { Id = id };
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}
