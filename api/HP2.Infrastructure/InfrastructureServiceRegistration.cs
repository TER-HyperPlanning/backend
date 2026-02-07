using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HP2.Infrastructure.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HP2.Application.Contracts;
using HP2.Infrastructure.Repositories;

namespace HP2.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddDbContext<TerHyperplanningContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LocalConnection")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            //services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
            // services.AddScoped<IMatiereTestRepository, MatiereTestRepository>();
            // services.AddScoped<SeanceTestRepository, SeanceTestRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<ICategorieRepository, CategorieRepository>();
            //services.AddScoped<ITagRepository, TagRepository>();
            //services.AddScoped<IParticipationRepository, ParticipationRepository>();
            //services.AddScoped<ISortieFavoriteRepository, SortieFavoriteRepository>();
            //services.AddScoped<ISignalementSortieRepository, SignalementSortieRepository>();
            //services.AddScoped<ICommentaireRepository, CommentaireRepository>();
            //services.AddScoped<INoterSortieRepository, NoterSortieRepository>();
            //services.AddScoped<ISignalementCommentaireRepository, SignalementCommentaireRepository>();

            return services;
        }
    }
}
