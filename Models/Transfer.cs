namespace StockPulse.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int FromWarehouseId { get; set; }
        public Warehouse FromWarehouse { get; set; }
        public int ToWarehouseId { get; set; }
        public Warehouse ToWarehouse { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
