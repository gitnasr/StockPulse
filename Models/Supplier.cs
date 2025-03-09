namespace StockPulse.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public List<Stock> Stock { get; set; }

    }
}
