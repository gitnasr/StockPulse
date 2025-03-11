using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;

namespace StockPulse.Views
{
    public partial class SupplyPremitController : UserControl
    {
        SupplierService supplierService = new SupplierService();
        SupplyPermissionService supplyPermissionService = new SupplyPermissionService();
        StockService stockService = new StockService();

        public SupplyPremitController()
        {
            InitializeComponent();
            LoadStocks();
            LoadSupplyPremit();
        }
        private void LoadStocks()
        {
            var stocks = stockService.GetStocksWithoutSuppliers();
            ItemList.DataSource = stocks;
            ItemList.DisplayMember = "Name";
            ItemList.ValueMember = "Id";
        }


        private void ResetFields()
        {
            SupplierNameTextBox.Text = "";
            SupplierPhoneTextBox.Text = "";
            SupplierFaxTextBox.Text = "";
            SupplierEmailTextBox.Text = "";
            SupplierWebsiteTextBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = SupplierNameTextBox.Text;
            string Phone = SupplierPhoneTextBox.Text;
            string Fax = SupplierFaxTextBox.Text;
            string Email = SupplierEmailTextBox.Text;
            string Website = SupplierWebsiteTextBox.Text;

            supplierService.CreateSupplier(Name, Phone, Fax, Email, Website);
            Alerts.ShowSuccess("Supplier created successfully");
            LoadSuppliers();
            ResetFields();
            LoadStocks();

        }
        private void LoadSuppliers()
        {

            List<Supplier> Suppliers = supplierService.GetAllSuppliers();

            SuppliersView.DataSource = Suppliers;
            SupplierComboBox.DataSource = Suppliers;
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "Id";

        }
        private void LoadSupplyPremit()
        {
            List<SupplyPremit> supplyPermissions = supplyPermissionService.GetAllSupplyPermissions();
            SupplyPremitView.DataSource = supplyPermissions;
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void CreatePremitButton_Click(object sender, EventArgs e)
        {
            DateTime ManufacturedAt = ManufacturedAtPicker.Value;
            DateTime ExpiresAt = ExpiresAtPick.Value;
            List<Stock> Items = ItemList.SelectedItems.Cast<Stock>().ToList();
            int SupplierId = (int)SupplierComboBox.SelectedValue;
            supplyPermissionService.CreateSupplyPermission(SupplierId, ManufacturedAt, ExpiresAt, Items);

            //Alerts.ShowSuccess("Supply premit created successfully");
            LoadSupplyPremit();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
