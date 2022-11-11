using GeekMapsApi.Infrastructure.Data;
using GeekMapsApi.Infrastructure.Repository;
using GeekMapsApi.Infrastructure.Repository.Interfaces;
using GeekMapsApi.Services;
using GeekMapsApi.Services.Interfaces;
using GeekMapsApi.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GeekMapsApi.Configurations;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DBConnectionString");

        //Config Services
        services.AddDbContext<GeekMapsDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.EnableSensitiveDataLogging(true);
        });

        var key = Encoding.ASCII.GetBytes(JwtSettings.Key);
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

        services.AddCors();

        //Application
        services.AddScoped<IAdministradorService, AdministradorService>();
        services.AddScoped<IEventoService, EventoService>();

        //Infrastructure
        services.AddScoped<IAdministradorRepository, AdministradorRepository>();

        return services;
    }
}
