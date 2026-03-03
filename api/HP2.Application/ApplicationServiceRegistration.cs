using HP2.Application.Contracts;
using HP2.Application.Security;
using Microsoft.Extensions.DependencyInjection;

namespace HP2.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IProgramService, ProgramService>();
            services.AddScoped<IBuildingService, BuildingService>();

            return services;
        }
    }
}
