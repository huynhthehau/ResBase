using Microsoft.EntityFrameworkCore;
using RestaurantManager.Domain.Entities;

namespace RestaurantManager.Infrastructure.Presistence
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
