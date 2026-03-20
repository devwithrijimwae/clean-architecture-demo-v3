using WebApi.Services;

namespace Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            // Add infrastructure services here

            services.AddTransient<IEmailService, EmailService>();

        }
    }
}