using RestaurantManager.Application.Common.Interfaces.Services;

namespace RestaurantManager.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
