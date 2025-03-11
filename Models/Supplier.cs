namespace StockPulse.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        public ICollection<SupplyPremit> SupplyPremits { get; set; } = new List<SupplyPremit>();


        public override string ToString()
        {
            return Name;
        }
    }
}
