using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPulse.Models
{
    [Table("Warehouse")]
    public class Warehouse
    {
        [Key]
        public int Id { get; private set; }
        [StringLength(255)]
        public string Address { get; set; }

        [ForeignKey("ManagerId")]
        public Manager Manager { get; set; }
        public DateTime CreateAt { get; private set; } = DateTime.UtcNow;

        public string Name { get; set; }
    }
}
