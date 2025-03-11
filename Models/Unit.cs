namespace StockPulse.Models
{

    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StockUnit> StockUnits { get; set; } = new List<StockUnit>();

        public override string ToString()
        {
            return Name;
        }

    }

}
