using Microsoft.EntityFrameworkCore;
using StockPulse.Models;
namespace StockPulse.Services
{
    public class WarehouseService
    {

        public List<Warehouse> GetWarehouses()
        {
            using (var db = new Database())
            {
                var warehouses = db.Warehouses.ToList();
                return warehouses;
            }
        }
        public List<Warehouse> GetWarehousesWithManager()
        {
            using (var db = new Database())
            {
                var warehouses = db.Warehouses.Include((warehouse) => warehouse.Manager).ToList();
                return warehouses;
            }
        }
        public void DeleteWarehouseById(int id)
        {
            using (var db = new Database())
            {
                var warehouse = db.Warehouses.First((warehouse) => warehouse.Id == id);
                db.Warehouses.Remove(warehouse);
                db.SaveChanges();
            }
        }

        public Warehouse GetWarehouseById(int id)
        {
            using (var db = new Database())
            {
                var warehouse = db.Warehouses.Include((warehouse) => warehouse.Manager).First((warehouse) => warehouse.Id == id);
                return warehouse;
            }
        }

        public void CreateWarehouse(string name, string address, int managerId)
        {
            using (var db = new Database())
            {
                var warehouse = new Warehouse
                {
                    Name = name,
                    Location = address,
                    Manager = db.Managers.First((manager) => manager.Id == managerId)
                };
                db.Warehouses.Add(warehouse);
                db.SaveChanges();
            }
        }

        public void UpdateWarehouseById(int warehouseId, string warehouseName, string warehouseAddress, int managerId)
        {
            using (var db = new Database())
            {

                var warehouse = db.Warehouses.First((warehouse) => warehouse.Id == warehouseId);
                warehouse.Name = warehouseName;
                warehouse.Location = warehouseAddress;
                warehouse.Manager = db.Managers.First((manager) => manager.Id == managerId);
                db.SaveChanges();

            }
        }
    }
}
