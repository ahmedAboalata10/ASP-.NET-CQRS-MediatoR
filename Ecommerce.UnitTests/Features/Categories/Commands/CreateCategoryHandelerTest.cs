using AutoMapper;
using Ecommerce.UnitTests.Mocks;
using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.Features.Categories.Handelers.Commands;
using Ecommmerce.Application.Features.Categories.Handelers.Queries;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.MappingProfiles;
using Ecommmerce.Application.Persistance.Contracts;
using Ecommmerce.Application.Responses;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.UnitTests.Features.Categories.Commands
{
    public class CreateCategoryHandelerTest
    {
        private readonly IMapper mapper;
        private readonly Mock<ICategoryRepository> mock;
        private readonly CategoryDTO category;
        public CreateCategoryHandelerTest()
        {
            mock = MockCategriesRepository.GetCategoryRepository();
            var mapconfig = new MapperConfiguration(c =>
            {
                c.AddProfile<CategoryMappingProfile>();
            });
            mapper = mapconfig.CreateMapper();
            category = new CategoryDTO { Id = 11, Name = "Test Create " };
        }
        [Fact]
        public async Task CreateCategory()
        {
            var handler = new CreateCategoryHandeler(mock.Object, mapper);
            var result = await handler.Handle(new CreateCategoryRequest { CategoryDTO = category }, CancellationToken.None);
            result.ShouldBeOfType<BaseCommandResponse>();
        }
        [Fact]
        public async Task CreateCategoryAndGetCount()
        {
            var handler = new CreateCategoryHandeler(mock.Object, mapper);
            var result = await handler.Handle(new CreateCategoryRequest { CategoryDTO = category }, CancellationToken.None);
            var categories = await mock.Object.GetAllAsync();
            Assert.Equal(8, categories.Count);
        }
    }
}
