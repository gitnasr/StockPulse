namespace StockPulse.Models
{
    public class StockUnit
    {
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
