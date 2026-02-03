using Microsoft.Extensions.DependencyInjection;

namespace HP2.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMatiereTestService, MatiereTestService>();

            return services;
        }
    }
}
