using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockPulse.Models.Configuration
{
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasKey(w => w.Id);

            builder.Property(w => w.Name)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(w => w.Location)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.HasIndex(w => w.Name).IsUnique();

            builder.HasOne(w => w.Manager)
                   .WithOne(m => m.Warehouse)
                   .HasForeignKey<Warehouse>(w => w.ManagerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
