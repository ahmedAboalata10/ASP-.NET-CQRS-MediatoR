using AutoMapper;
using Castle.Core.Smtp;
using Ecommerce.UnitTests.Mocks;
using Ecommmerce.Application.DTO.Entities.Category;
using Ecommmerce.Application.DTO.Entities.Product;
using Ecommmerce.Application.Features.Categories.Handelers.Commands;
using Ecommmerce.Application.Features.Categories.Handelers.Queries;
using Ecommmerce.Application.Features.Categories.Requests.Commands;
using Ecommmerce.Application.Features.Product.Requests.Commands;
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

namespace Ecommerce.UnitTests.Features.Products
{
    public class CreateProductHandelerTest
    {
        private readonly IMapper mapper;
        private readonly Mock<IProductRepository> mock;
        private readonly ProductDTO product;
        public CreateProductHandelerTest()
        {
            mock=  MockProductsRepository.GetProductRepository();
            var mapconfig = new MapperConfiguration(c =>
            {
                c.AddProfile<ProductMappingProfile>();
            });
            mapper=mapconfig.CreateMapper();
            product = new ProductDTO { Id=11, Name="Test create Product ", CategoryId=4, Price=-182 };
           
            }
        [Fact]
        public async Task Test_Respone_Of_Product()
        {
            var handler = new CreateProductHandeler(mock.Object, mapper);
            var result = await handler.Handle(new CreateProductRequest { ProductDTO = product }, CancellationToken.None);
            result.ShouldBeOfType<BaseCommandResponse>();
            var products = await mock.Object.GetAllAsync();
            products.Count.ShouldBe(7);
        }
        
    }
}
