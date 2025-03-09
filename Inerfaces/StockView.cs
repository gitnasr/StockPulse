public interface IStockViewModel
{
    int Id { get; set; }
    string Name { get; set; }
    int Quantity { get; set; }
    string Code { get; set; }
    decimal Price { get; set; }
    string Warehouse { get; set; }
    string UnitNames { get; set; }
}

namespace StockPulse.Inerfaces
{
    public class StockViewModel : IStockViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Warehouse { get; set; }
        public string UnitNames { get; set; }
    }

}
