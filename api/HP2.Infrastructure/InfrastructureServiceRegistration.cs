using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HP2.Infrastructure.Persistence.Entities;
using System.Reflection;
using HP2.Application.Contracts;
using HP2.Infrastructure.Repositories;


namespace HP2.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddDbContext<TerHyperplanningContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LocalConnection")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWeekDayRepository, WeekDayRepository>();

            //services.AddScoped<ICategorieRepository, CategorieRepository>();
            //services.AddScoped<ITagRepository, TagRepository>();
            //services.AddScoped<IParticipationRepository, ParticipationRepository>();
            //services.AddScoped<ISortieFavoriteRepository, SortieFavoriteRepository>();
            //services.AddScoped<ISignalementSortieRepository, SignalementSortieRepository>();
            //services.AddScoped<ICommentaireRepository, CommentaireRepository>();
            //services.AddScoped<INoterSortieRepository, NoterSortieRepository>();
            //services.AddScoped<ISignalementCommentaireRepository, SignalementCommentaireRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();

            return services;
        }
    }
}
