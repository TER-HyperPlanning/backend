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
            services.AddScoped<IWeekDayService, WeekDayService>();

            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IBCryptService, BCryptService>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IAttendService, AttendService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITrackService, TrackService>();
            services.AddScoped<IRoomService, RoomService>();

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
            
            return services;
        }
    }
}
