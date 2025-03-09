using Microsoft.EntityFrameworkCore;
using StockPulse.Inerfaces;
using StockPulse.Models;



namespace StockPulse.Services
{
    public class StockService
    {

        public List<StockViewModel> GetStocks()
        {
            using (var db = new Database())
            {
                var stocks = db.Stocks
                    .Include(stock => stock.Warehouse)
                    .Include(stock => stock.Units)
                    .Select(stock => new
                   StockViewModel
                    {
                        Id = stock.Id,
                        Name = stock.Name,
                        Quantity = stock.Quantity,
                        Code = stock.Code,
                        Price = stock.Price,
                        Warehouse = stock.Warehouse.Name,
                        UnitNames = string.Join(", ", stock.Units.Select(u => u.Name))
                    })
                    .ToList();

                return stocks;
            }
        }

        public void CreateNewStock(string ItemName, string ItemCode, int Quantity, int Price, int[] UnitIds, int WarehouseId)

        {
            using (var db = new Database())
            {

                Stock stock = new Stock
                {
                    Name = ItemName,
                    Code = ItemCode,
                    Quantity = Quantity,
                    Price = Price,
                    Units = db.Units.Where((unit) => UnitIds.Contains(unit.Id)).ToList(),
                    Warehouse = db.Warehouses.Find(WarehouseId)
                };
                db.Stocks.Add(stock);
                db.SaveChanges();


            }
        }
    }
}
