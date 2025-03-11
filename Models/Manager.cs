namespace StockPulse.Models
{

    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Warehouse Warehouse { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
