using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace StockPulse.Models.Configuration
{
    public class SupplyPremitConfiguration : IEntityTypeConfiguration<SupplyPremit>
    {
        public void Configure(EntityTypeBuilder<SupplyPremit> builder)
        {
            builder.HasKey(sp => sp.Id);

            builder.HasOne(sp => sp.Supplier)
                   .WithMany(s => s.SupplyPremits)
                   .HasForeignKey(sp => sp.SupplierId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
