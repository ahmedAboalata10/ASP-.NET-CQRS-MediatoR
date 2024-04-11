using Ecommerce.Domain.Entities;
using Ecommerce.Persistence.DataBaseContext;
using Ecommmerce.Application.Persistance.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDBContext context;

        public ProductRepository(ApplicationDBContext context) : base(context)
        {
            this.context=context;
        }

        public async Task<List<Product>> GetAllProductsWithInclude()
        {
           return await context.Products.AsNoTracking().Include(x=>x.Category).ToListAsync();   
        }
    }
}
