using Ecommerce.Infrastructure.Email;
using Ecommmerce.Application.Persistance.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infrastructure.Shared
{
    public static class InfrastructureRegiterationArea
    {
        public static void ConfiureInfrastrctureServise(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSender>(configuration.GetSection("EmailSettings"));
            services.AddScoped<IEmailSender, EmailSender>();
        }
    }
}
