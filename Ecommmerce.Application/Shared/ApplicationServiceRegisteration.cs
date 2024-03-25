using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommmerce.Application.Shared
{
    public static class ApplicationServiceRegisteration
    {
        public static void ConfigureApllicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
