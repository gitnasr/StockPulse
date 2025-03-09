using System.ComponentModel.DataAnnotations.Schema;

namespace StockPulse.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Code { get; set; }

        public decimal Price { get; set; }

        public List<Unit> Units { get; set; } = new List<Unit>();

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}
