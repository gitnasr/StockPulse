using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;

namespace StockPulse.Views
{
    public partial class TransferView : UserControl
    {
        private WarehouseService warehouseService = new WarehouseService();
        private StockService stockService = new StockService();
        private TransferService transferService = new TransferService();
        public TransferView()
        {
            InitializeComponent();
        }

        private void TransferView_Load(object sender, EventArgs e)
        {
            List<Warehouse> fwarehouses = warehouseService.GetWarehouses();
            List<Warehouse> twarehouses = [.. fwarehouses];

            FromWarehouse.DataSource = fwarehouses;
            FromWarehouse.DisplayMember = "Name";
            FromWarehouse.ValueMember = "Id";

            ToWarehouse.DataSource = twarehouses;
            ToWarehouse.DisplayMember = "Name";
            ToWarehouse.ValueMember = "Id";


        }

        private void FromWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            var fromWarehouse = FromWarehouse.SelectedItem as Warehouse;

            if (fromWarehouse == null)
            {
                Alerts.ShowError("Please select a warehouse");
                return;
            }

            List<Stock> fromStocks = stockService.GetStocksByWarehouseId(fromWarehouse.Id);

            FromItem.DataSource = fromStocks;
            FromItem.DisplayMember = "Name";
            FromItem.ValueMember = "Id";
            FromItem.Enabled = true;

            ToWarehouse.Enabled = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fromWarehouse = FromWarehouse.SelectedItem as Warehouse;
            var toWarehouse = ToWarehouse.SelectedItem as Warehouse;
            var stock = FromItem.SelectedItem as Stock;
            if (fromWarehouse == null || toWarehouse == null || stock == null)
            {
                Alerts.ShowError("Please select a warehouse and stock");
                return;
            }
            if (fromWarehouse.Id == toWarehouse.Id)
            {
                Alerts.ShowError("Cannot transfer to the same warehouse");
                return;
            }
            transferService.Create(fromWarehouse.Id, toWarehouse.Id, stock.Id);
            Alerts.ShowSuccess("Transfer successful");

        }
    }
}
