using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;

namespace StockPulse.Views
{
    public partial class DisposePremit : UserControl
    {

        private CustomerService CustomerService = new CustomerService();
        private SupplierService SupplierService = new SupplierService();
        private DisposePremitService DisposePremitService = new DisposePremitService();
        public DisposePremit()
        {
            InitializeComponent();
            LoadDisposePremits();

        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            Customer Customer = new Customer
            {
                Name = CustomerName.Text,
                Email = CustomerEmail.Text,
                Phone = CustomerPhone.Text,
                Fax = CustomerFax.Text,
                Website = CustomerWebsite.Text

            };

            CustomerService.CreateCustomer(Customer);


            Alerts.ShowSuccess("Customer created successfully");
        }

        private void DisposePremit_Load(object sender, EventArgs e)
        {
            CustomerComboBox.DataSource = CustomerService.GetCustomers();
            CustomerComboBox.DisplayMember = "Name";

            SupplierComboBox.DataSource = SupplierService.GetAllSuppliers();


        }

        private void ItemList_MouseHover(object sender, EventArgs e)
        {
        }

        private void FetchItemsButton_Click(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedItem != null && CustomerComboBox.SelectedItem != null)
            {
                Supplier Supplier = (Supplier)SupplierComboBox.SelectedItem;
                List<Stock> Items = SupplierService.GetItemsBySupplierId(Supplier.Id);
                ItemList.DataSource = Items;
                ItemList.DisplayMember = "Name";
            }

        }
        private void LoadDisposePremits()
        {
            DisposePremitView.DataSource = DisposePremitService.GetAllDisposePremits();
        }
        private void CreatePremitButton_Click(object sender, EventArgs e)
        {
            var itemsIds = ItemList.SelectedItems.Cast<Stock>().Select(stock => stock.Id).ToArray();
            DisposePremitService.Create(((Supplier)SupplierComboBox.SelectedItem).Id, itemsIds, ((Customer)CustomerComboBox.SelectedItem).Id);
            LoadDisposePremits();
        }
    }
}
