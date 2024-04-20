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
    public static class MockCategriesRepository
    {
        public static Mock<ICategoryRepository> GetCategoryRepository()
        {
            var categories = new List<Category>
                {
                    new () { Id =1, Name ="cat_one",Description="des_one"},
                    new () { Id =2, Name ="cat_two",Description="des_two"},
                    new () { Id =3, Name ="cat_three",Description="des_three"},
                    new () { Id =4, Name ="cat_four",Description="des_four"},
                    new () { Id =5, Name ="cat_five",Description="des_five"},
                    new () { Id =6, Name ="cat_six",Description="des_six"},
                    new () { Id =7, Name ="cat_seven",Description="des_seven"},
                };
            var moqRepo = new Mock<ICategoryRepository>();
            moqRepo.Setup(x => x.GetAllAsync()).ReturnsAsync(categories);
            moqRepo.Setup(x => x.CreateAsync(It.IsAny<Category>())).Returns((Category category) =>
            {
                categories.Add(category);
                return Task.CompletedTask;
            });
            return moqRepo;
        }

    }
}
