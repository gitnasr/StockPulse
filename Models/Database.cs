

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

        public DbSet<SupplyPremit> SupplyPermissions { get; set; }

        public DbSet<StockUnit> StockUnits { get; set; }

        public DbSet<DisposePremit> DisposePremits { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Database).Assembly);
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
