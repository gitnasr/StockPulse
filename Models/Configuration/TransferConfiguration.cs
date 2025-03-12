using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockPulse.Models.Configuration
{
    public class TransferConfiguration : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Date).HasDefaultValueSql("getdate()");
            builder.HasOne(t => t.Stock).WithMany().HasForeignKey(t => t.StockId);
            builder.HasOne(t => t.FromWarehouse).WithMany().HasForeignKey(t => t.FromWarehouseId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.ToWarehouse).WithMany().HasForeignKey(t => t.ToWarehouseId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Transfers");


        }
    }
}
