using StockPulse.Models;

namespace StockPulse.Services
{
    public class TransferService
    {
        public void Create(int fromWarehouseId, int toWarehouseId, int StockId)
        {
            WarehouseService warehouseService = new WarehouseService();
            StockService stockService = new StockService();

            var fromWarehouse = warehouseService.GetWarehouseById(fromWarehouseId);
            var toWarehouse = warehouseService.GetWarehouseById(toWarehouseId);
            var stock = stockService.GetStockById(StockId);

            stock.Warehouse = toWarehouse;
            stockService.UpdateStock(stock);

            Transfer transfer = new Transfer
            {
                StockId = StockId,
                FromWarehouseId = fromWarehouseId,
                ToWarehouseId = toWarehouseId,
            };


            using (var db = new Database())
            {
                db.Add(transfer);
                db.SaveChanges();

            }
        }

        public List<Transfer> GetTransfers()
        {
            using (var db = new Database())
            {
                return db.Transfers.ToList();
            }
        }
    }
}
