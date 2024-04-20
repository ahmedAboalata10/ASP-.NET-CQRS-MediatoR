using Ecommerce.Domain.Entities;
using Ecommmerce.Application.Persistance.Contracts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.UnitTests.Mocks
{
    public static class MockProductsRepository
    {
        public static Mock<IProductRepository> GetProductRepository()
        {
            var products = new List<Product>
                {
                    new () { Id =1, Name ="Prod_one",  Description="des_one"   ,Price=100, CategoryId=2},
                    new () { Id =2, Name ="Prod_two",  Description="des_two"   ,Price=100, CategoryId=3},
                    new () { Id =3, Name ="Prod_three",Description="des_three" ,Price=100, CategoryId=9},
                    new () { Id =4, Name ="Prod_four", Description="des_four"  ,Price=100, CategoryId=5},
                    new () { Id =5, Name ="Prod_five", Description="des_five"  ,Price=100, CategoryId=4},
                    new () { Id =6, Name ="Prod_six",  Description="des_six"   ,Price=100, CategoryId=5},
                    new () { Id =7, Name ="Prod_seven",Description="des_seven" ,Price=100, CategoryId=1},
                };
            var moqRepo = new Mock<IProductRepository>();
            moqRepo.Setup(x => x.GetAllAsync()).ReturnsAsync(products);
            moqRepo.Setup(x => x.CreateAsync(It.IsAny<Product>())).Returns((Product product) =>
            {
                products.Add(product);
                return Task.CompletedTask;
            }); 
            return moqRepo;
        }
    }
}
