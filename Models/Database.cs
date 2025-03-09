

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace StockPulse.Models
{
    public class Database : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Manager> Managers { get; set; }
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
