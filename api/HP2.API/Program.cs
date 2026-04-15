using System.Reflection;
using System.Text.Json.Serialization;
using HP2.Application;
using HP2.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("LocalConnection");
        Console.WriteLine($"Connexion String récupérée : {connectionString}");

        // ===== Configuration JWT =====
        var jwtSettings = builder.Configuration.GetSection("JWT");
        var secretKey = jwtSettings["SecretKey"] ?? throw new InvalidOperationException("JWT:SecretKey is not configured");
        var issuer = jwtSettings["ValidIssuer"] ?? throw new InvalidOperationException("JWT:ValidIssuer is not configured");
        var audience = jwtSettings["ValidAudience"] ?? throw new InvalidOperationException("JWT:ValidAudience is not configured");

        // ===== Add Services =====
        builder.Services.AddApplicationServices();
        builder.Services.AddJwtService(issuer, audience, secretKey);

        builder.Services.AddInfrastructureServices(builder.Configuration);

        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

        builder.Services.AddControllers()
            .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

        // Disable automatic 400 response so controllers can return ApiResponse wrapper
        builder.Services.Configure<Microsoft.AspNetCore.Mvc.ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });

        builder.Services.AddDbContext<HP2.Infrastructure.Persistence.Entities.TerHyperplanningContext>(options =>
            options.UseSqlServer(connectionString)
                   .LogTo(Console.WriteLine, LogLevel.Error));

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Entrez votre token JWT"
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
        });

        // ===== Configure JWT Authentication =====
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ClockSkew = TimeSpan.Zero // Par défaut EF6 ajoute 5min de tolerance
            };
        });

        // 🔹 Configure JSON pour utiliser les noms d'enum
        builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<HP2.Infrastructure.Persistence.Entities.TerHyperplanningContext>();
            db.Database.Migrate();
        }

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // app.UseHttpsRedirection();

        app.UseCors(opt => opt.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader());

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
