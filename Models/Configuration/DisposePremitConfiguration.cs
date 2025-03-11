
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockPulse.Models.Configuration
{
    class DisposePremitConfiguration : IEntityTypeConfiguration<DisposePremit>
    {
        public void Configure(EntityTypeBuilder<DisposePremit> builder)
        {

            builder.HasOne(d => d.Customer)
                .WithMany(c => c.DisposePremits)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.Supplier)
                .WithMany(s => s.DisposePremits)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);


        }


    }
}
