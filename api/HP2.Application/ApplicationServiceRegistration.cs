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
<<<<<<< Updated upstream
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IBCryptService, BCryptService>();

            return services;
        }

        public static IServiceCollection AddJwtService(
            this IServiceCollection services,
            string issuer,
            string audience,
            string secretKey,
            int expirationMinutes = 1440)
        {
            services.AddScoped<IJWTService>(provider =>
                new JWTService(issuer, audience, secretKey, expirationMinutes));
=======
            services.AddScoped<IProgramService, ProgramService>();
            services.AddScoped<IBuildingService, BuildingService>();
>>>>>>> Stashed changes

            return services;
        }
    }
}
