using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace RestaurantManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services,
                                                           ConfigurationManager configuration)
        {
            return services;
        }
    }
}
