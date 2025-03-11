using Microsoft.EntityFrameworkCore;
using StockPulse.Models;

namespace StockPulse.Services
{
    class SupplyPermissionService
    {
        public List<SupplyPremit> GetAllSupplyPermissions()
        {
            using (var db = new Database())
            {
                return db.SupplyPermissions
                    .Include(supplyPermission => supplyPermission.Supplier)
                    .Include(supplyPermission => supplyPermission.Stocks)
                    .ToList();


            }
        }

        public void CreateSupplyPermission(int supplierID, DateTime manfacturedAt, DateTime expiresAt, List<Stock> Items)
        {
            using (var db = new Database())
            {
                var trackedSupplier = db.Suppliers.Find(supplierID);
                var trackedItems = db.Stocks.Where(stock => Items.Contains(stock)).ToList();
                SupplyPremit supplyPremit = new SupplyPremit
                {
                    Supplier = trackedSupplier,
                    AddedAt = DateTime.Now,
                    ExpiresAt = expiresAt,
                    ManufacturedAt = manfacturedAt,
                    Stocks = trackedItems
                };
                db.Add(supplyPremit);
                db.SaveChanges();
            }
        }
    }
}