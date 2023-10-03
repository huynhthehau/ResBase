using Microsoft.EntityFrameworkCore;
using RestaurantManager.Domain.Entities;

namespace RestaurantManager.Infrastructure.Persistence
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ItemAdditionNotification> ItemAdditionNotifications { get; set; }
        public DbSet<ItemCancellationNotification> ItemCancellationNotifications { get; set; }
        public DbSet<KitchenNotificationHistory> KitchenNotificationHistories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemAndCategory> MenuItemAndCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAndTable> OrderAndTables { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ReadyToServeNotification> ReadyToServeNotifications { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAndAuthority> RoleAndAuthorities { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<UserInformation> Users { get; set; }
    }
}
