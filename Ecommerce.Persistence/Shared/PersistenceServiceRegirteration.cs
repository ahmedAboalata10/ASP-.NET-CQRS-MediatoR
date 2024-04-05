using Ecommerce.Persistence.DataBaseContext;
using Ecommerce.Persistence.Persistence;
using Ecommmerce.Application.Persistance.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Shared
{
    public static class PersistenceServiceRegirteration
    {
        public static void ConfiurePersistenceServise(this IServiceCollection services,IConfiguration configuration)
        {
            //DB Context
            services.AddDbContext<ApplicationDBContext>
                (opt=> opt.UseSqlServer(configuration.GetConnectionString("Default"))
            );

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
        }

    }
}
