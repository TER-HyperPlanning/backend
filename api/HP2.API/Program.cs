using System.Reflection;
using System.Text.Json.Serialization;
using HP2.Application;
using HP2.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.Mvc;

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

        builder.Services.Configure<ApiBehaviorOptions>(options =>
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var errors = context.ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                    .SelectMany(x => x.Value!.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                var message = errors.Any()
                    ? string.Join(" | ", errors)
                    : "Invalid request payload.";

                return new BadRequestObjectResult(ApiResponse<object>.Fail(message));
            };
        });

        builder.Services.AddDbContext<HP2.Infrastructure.Persistence.Entities.TerHyperplanningContext>(options =>
            options.UseSqlServer(connectionString)
                   .LogTo(Console.WriteLine, LogLevel.Error));

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
                    Array.Empty<string>()
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
                ClockSkew = TimeSpan.Zero
            };
        });

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<HP2.Infrastructure.Persistence.Entities.TerHyperplanningContext>();
            db.Database.Migrate();
        }

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(opt => opt.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader());

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}