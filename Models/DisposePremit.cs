namespace StockPulse.Models
{
    public class DisposePremit
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }



    }
}
