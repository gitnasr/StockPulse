using StockPulse.Models;

namespace StockPulse.Dialog
{
    public partial class SupplyPremitItems : Form
    {
        public SupplyPremitItems(ICollection<Stock> supplier)
        {
            InitializeComponent();
            SupplyPremitView.DataSource = supplier;
        }
    }
}
