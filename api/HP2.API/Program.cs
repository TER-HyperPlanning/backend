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
using HP2.Application.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Text.Json;

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

        // SignalR pour les notifications en temps réel
        builder.Services.AddSignalR();
        builder.Services.AddScoped<HP2.Application.Contracts.INotificationService, global::HP2.API.Services.NotificationService>();

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

            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var accessToken = context.Request.Query["access_token"];
                    var path = context.HttpContext.Request.Path;
                    if (!string.IsNullOrEmpty(accessToken) &&
                        (path.StartsWithSegments("/hubs/notifications")))
                    {
                        context.Token = accessToken;
                    }
                    return Task.CompletedTask;
                },
                OnChallenge = context =>
                {
                    context.HandleResponse();
                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";
                    var jsonOptions = new System.Text.Json.JsonSerializerOptions
                    {
                        PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
                    };
                    var result = System.Text.Json.JsonSerializer.Serialize(ApiResponse<object>.Fail("You are not authenticated to access this resource. (Missing or invalid token)"), jsonOptions);
                    return context.Response.WriteAsync(result);
                },
                OnForbidden = context =>
                {
                    context.Response.StatusCode = 403;
                    context.Response.ContentType = "application/json";
                    var jsonOptions = new System.Text.Json.JsonSerializerOptions
                    {
                        PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
                    };
                    var result = System.Text.Json.JsonSerializer.Serialize(ApiResponse<object>.Fail("Access denied. You do not have the required permissions to access this resource."), jsonOptions);
                    return context.Response.WriteAsync(result);
                }
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

        app.UseExceptionHandler(errorApp =>
        {
            errorApp.Run(async context =>
            {
                var exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;

                context.Response.ContentType = "application/json";

                var (statusCode, errorResponse) = exception switch
                {
                    DeleteConflictException ex =>
                        (StatusCodes.Status409Conflict, ApiResponse<object>.Fail(ex.Message, ex.BlockingSession)),

                    ArgumentException ex =>
                        (StatusCodes.Status400BadRequest, ApiResponse<object>.Fail(ex.Message)),

                    FormatException ex =>
                        (StatusCodes.Status400BadRequest, ApiResponse<object>.Fail(ex.Message)),

                    KeyNotFoundException ex =>
                        (StatusCodes.Status400BadRequest, ApiResponse<object>.Fail(ex.Message)),

                    UnauthorizedAccessException ex =>
                        (StatusCodes.Status403Forbidden, ApiResponse<object>.Fail(ex.Message)),

                    _ =>
                        (StatusCodes.Status500InternalServerError, ApiResponse<object>.Fail("An internal error occurred"))
                };

                context.Response.StatusCode = statusCode;

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse, jsonOptions));
            });
        });

        app.UseCors(opt => opt
            .WithOrigins("http://localhost","http://localhost:3000", "http://localhost:5173", "https://hyper-planning.fr")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()); // Requis pour SignalR WebSockets

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();
        app.MapHub<global::HP2.API.Hubs.NotificationHub>("/hubs/notifications");

        app.Run();
    }
}