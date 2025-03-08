

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace StockPulse.Models
{
    class Database : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Manager> Managers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
            string encryptedConnStr = config["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(encryptedConnStr);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
