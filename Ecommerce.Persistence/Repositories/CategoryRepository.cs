using Ecommerce.Domain.Entities;
using Ecommerce.Persistence.DataBaseContext;
using Ecommmerce.Application.Persistance.Contracts;


namespace Ecommerce.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
