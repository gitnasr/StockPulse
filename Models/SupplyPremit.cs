namespace StockPulse.Models
{
    public class SupplyPremit
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime ManufacturedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public List<Stock> Stock { get; set; }
    }
}
