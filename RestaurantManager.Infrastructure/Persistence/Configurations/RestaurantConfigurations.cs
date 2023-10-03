using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantManager.Domain.Entities;

namespace RestaurantManager.Infrastructure.Persistence.Configurations
{
    public class RestaurantConfigurations : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            ConfigureMenusTable(builder);
        }

        private void ConfigureMenusTable(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurants");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id, value => new Guid());

            builder.Property(r => r.Name)
            .HasMaxLength(100);

            builder.Property(r => r.Address)
            .HasMaxLength(500);
        }
    }
}
