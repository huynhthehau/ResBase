using Microsoft.EntityFrameworkCore;
using RestaurantManager.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Infrastructure.Presistence
{
    public class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options):base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
