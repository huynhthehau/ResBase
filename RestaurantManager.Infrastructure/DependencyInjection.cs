using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantManager.Application.Common.Interfaces.Authentication;
using RestaurantManager.Application.Common.Interfaces.Services;
using RestaurantManager.Infrastructure.Authentication;
using RestaurantManager.Infrastructure.Services;

namespace RestaurantManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           ConfigurationManager configuration) {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider,DateTimeProvider>();
            return services;
        }
    }
}
