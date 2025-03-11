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
                    .Include(stock => stock.StockUnits)
                    .Select(stock => new
                   StockViewModel
                    {
                        Id = stock.Id,
                        Name = stock.Name,
                        Quantity = stock.Quantity,
                        Code = stock.Code,
                        Price = stock.Price,
                        Warehouse = stock.Warehouse.Name,
                        UnitNames = string.Join(", ", stock.StockUnits.Select(u => u.Stock.Name))
                    })
                    .ToList();

                return stocks;
            }
        }

        public List<Stock> GetStocksWithoutSuppliers()
        {

            using (var db = new Database())
            {
                return db.Stocks
                    .Include(stock => stock.Warehouse)
                    .Where(stock => stock.SupplyPremit == null)
                    .ToList();
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
                    //StockUnits = db.Units.Where((unit) =>
                    ////UnitIds.Contains(unit.Id)).Select((unit) => new StockUnit
                    ////{
                    ////    Stock = stock,
                    ////    Unit = unit
                    ////}).ToList(),
                    Warehouse = db.Warehouses.Find(WarehouseId)
                };
                db.Stocks.Add(stock);
                db.SaveChanges();


            }
        }
    }
}
