using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPulse.Models
{
    [Table("Warehouse")]
    class Warehouse
    {
        [Key]
        public int Id { get; private set; }
        [StringLength(255)]
        public string Address { get; set; }

        [ForeignKey("ManagerId")]
        public Manager manager { get; set; }
        public DateTime CreateAt { get; private set; } = DateTime.UtcNow;
    }
}
