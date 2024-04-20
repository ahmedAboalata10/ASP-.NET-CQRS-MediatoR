using AutoMapper;
using Ecommerce.UnitTests.Mocks;
using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.Features.Categories.Handelers.Queries;
using Ecommmerce.Application.MappingProfiles;
using Ecommmerce.Application.Persistance.Contracts;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.UnitTests.Features.Categories.Queries
{
    public class GetAllCategoriesHandelerTest
    {
        private readonly IMapper mapper;
        private readonly Mock<ICategoryRepository> mock;
        public GetAllCategoriesHandelerTest()
        {
            mock = MockCategriesRepository.GetCategoryRepository();
            var mapconfig = new MapperConfiguration(c =>
            {
                c.AddProfile<CategoryMappingProfile>();
            });
            mapper = mapconfig.CreateMapper();
        }
        [Fact]
        public async Task GetCategoryListTest()
        {
            var handler = new GetAllCategoriesHandeler(mock.Object, mapper);
            var result = await handler.Handle(new Ecommmerce.Application.Features.Categories.Requests.Queries.GetAllCategoriesRequest(), CancellationToken.None);
            result.ShouldBeOfType<List<CategoryDTO>>();
        }
        [Fact]
        public async Task GetCategoryListCountTest()
        {
            var handler = new GetAllCategoriesHandeler(mock.Object, mapper);
            var result = await handler.Handle(new Ecommmerce.Application.Features.Categories.Requests.Queries.GetAllCategoriesRequest(), CancellationToken.None);
            result.Count.ShouldBe(7);
        }
    }
}
