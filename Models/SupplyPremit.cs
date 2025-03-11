namespace StockPulse.Models
{
    public class SupplyPremit
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
        public DateTime ManufacturedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    }
}
