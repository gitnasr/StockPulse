using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockPulse.Models.Configuration
{
    public class StockUnitConfiguration : IEntityTypeConfiguration<StockUnit>
    {
        public void Configure(EntityTypeBuilder<StockUnit> builder)
        {
            builder.HasKey(su => new { su.StockId, su.UnitId });

            builder.HasOne(su => su.Stock)
                   .WithMany(s => s.StockUnits)
                   .HasForeignKey(su => su.StockId);

            builder.HasOne(su => su.Unit)
                   .WithMany(u => u.StockUnits)
                   .HasForeignKey(su => su.UnitId);
        }
    }
}
