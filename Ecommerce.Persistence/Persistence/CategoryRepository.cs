using Ecommerce.Domain.Entities;
using Ecommerce.Persistence.DataBaseContext;
using Ecommmerce.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Persistence
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
