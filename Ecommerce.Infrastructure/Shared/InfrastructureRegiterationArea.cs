using Ecommerce.Infrastructure.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Shared
{
    public static class InfrastructureRegiterationArea
    {
        public static void ConfiureInfrastrctureServise(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSender>(configuration.GetSection("EmailSetting"));
            services.AddTransient<EmailSender, EmailSender>();
        }
    }
}
