using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace StockPulse.Models.Configuration
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.HasIndex(s => new { s.WarehouseId, s.Code }).IsUnique();

            builder.Property(s => s.Price)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(s => s.Warehouse)
                   .WithMany(w => w.Stocks)
                   .HasForeignKey(s => s.WarehouseId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.SupplyPremit)
                   .WithMany(sp => sp.Stocks)
                   .HasForeignKey(s => s.SupplyPremitId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
