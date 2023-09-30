using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RestaurantManager.Application.Common.Interfaces.Authentication;
using RestaurantManager.Application.Common.Interfaces.Services;
using RestaurantManager.Infrastructure.Authentication;
using RestaurantManager.Infrastructure.Presistence;
using RestaurantManager.Infrastructure.Services;
using System.Text;

namespace RestaurantManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           ConfigurationManager configuration)
        {
            services.AddAuth(configuration);
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
        public static IServiceCollection AddAuth(this IServiceCollection services,
                                                           ConfigurationManager configuration)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);
            services.AddSingleton(Options.Create(JwtSettings));
            //services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options=>options.TokenValidationParameters= new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer=JwtSettings.Issuer,
                ValidAudience = JwtSettings.Audience,
                IssuerSigningKey = 
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(JwtSettings.Secret)
                )
        });
            return services;
        }

        public static IServiceCollection AddDb(this IServiceCollection services,
                                                           ConfigurationManager configuration)
        {
            services.AddDbContext<RestaurantDbContext>(options => options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=RestaurantManager;User Id=postgres;Password=150501;Timeout=15;"));
            return services;
        }
    }
}
