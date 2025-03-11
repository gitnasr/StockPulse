namespace StockPulse.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int? SupplyPremitId { get; set; }
        public SupplyPremit SupplyPremit { get; set; }
        public ICollection<StockUnit> StockUnits { get; set; } = new List<StockUnit>();
    }
}
