namespace StockPulse.Models
{

    public class Warehouse
    {

        public int Id { get; private set; }

        public string Address { get; set; }

        public Manager Manager { get; set; }
        public DateTime CreateAt { get; private set; } = DateTime.UtcNow;

        public string Name { get; set; }

        public List<Stock> Stocks { get; set; } = new List<Stock>();

        public override string ToString()
        {
            return Name;
        }
    }
}
