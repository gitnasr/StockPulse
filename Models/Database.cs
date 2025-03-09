

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace StockPulse.Models
{
    public class Database : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<SupplyPremit> SupplyPremits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
                .HasKey(Stock => new { Stock.WarehouseId, Stock.Code });
            modelBuilder.Entity<Stock>().Property(stock => stock.Id).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
            string? ConnectionString = config["ConnectionStrings:DefaultConnection"];
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new Exception("Connection string is missing from appsettings.json");
            }
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
