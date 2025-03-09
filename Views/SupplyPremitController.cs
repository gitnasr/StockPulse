using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;

namespace StockPulse.Views
{
    public partial class SupplyPremitController : UserControl
    {
        SupplierService supplierService = new SupplierService();

        public SupplyPremitController()
        {
            InitializeComponent();
        }

        private void SupplyPremitController_Load(object sender, EventArgs e)
        {

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
            LoadSupplier();
            ResetFields();
        }
        private void LoadSupplier()
        {

            List<Supplier> Suppliers = supplierService.GetAllSuppliers();

            SuppliersView.DataSource = Suppliers;


        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            LoadSupplier();
        }
    }
}
