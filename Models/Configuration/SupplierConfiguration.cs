using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockPulse.Models
{
    public partial class Supplier
    {
        public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
        {
            public void Configure(EntityTypeBuilder<Supplier> builder)
            {
                builder.HasKey(s => s.Id);

                builder.Property(s => s.Name)
                       .IsRequired()
                       .HasMaxLength(255);

                builder.Property(s => s.Phone)
                       .HasMaxLength(20);

                builder.Property(s => s.Email)
                       .HasMaxLength(255);


            }
        }
    }
}
