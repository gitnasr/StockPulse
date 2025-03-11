namespace StockPulse.Models
{

    public class Warehouse
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();
        public override string ToString()
        {
            return Name;
        }
    }
}
