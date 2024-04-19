using Ecommerce.Persistence.DataBaseContext;
using Ecommerce.Persistence.Repositories;
using Ecommmerce.Application.Persistance.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Persistence.Shared
{
    public static class PersistenceServiceRegirteration
    {
        public static void ConfiurePersistenceServise(this IServiceCollection services, IConfiguration configuration)
        {
            //DB Context
            services.AddDbContext<ApplicationDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
        }
    }
}
