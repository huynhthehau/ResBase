using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantManager.Domain.Entity;

namespace RestaurantManager.Infrastructure.Presistence.Configurations
{
    public class RestaurantConfigurations : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            ConfiguareMenusTable(builder);
        }

        private void ConfiguareMenusTable(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurants");
            builder.HasKey(m => m.Id);
        }
    }
}
