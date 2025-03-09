namespace StockPulse.Models
{

    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Stock> Stocks { get; set; } = new List<Stock>();

        public override string ToString()
        {
            return Name;
        }

    }
}
