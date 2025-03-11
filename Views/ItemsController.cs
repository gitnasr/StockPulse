using StockPulse.Dialog;
using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;
using System.Text;
namespace StockPulse
{

    public partial class ItemsController : UserControl
    {
        private readonly UnitService unitService = new UnitService();
        private readonly WarehouseService warehouseService = new WarehouseService();
        public ItemsController()
        {
            InitializeComponent();
        }
        private void LoadWarehouses()
        {
            ItemWarehouse.DataSource = warehouseService.GetWarehouses();
            ItemWarehouse.DisplayMember = "Name";
            ItemWarehouse.ValueMember = "Id";

            if (ItemWarehouse.Items.Count > 0)
            {
                ItemWarehouse.SelectedIndex = 0;
            }
        }
        private void ReloadUnits()
        {
            UnitsListBox.DataSource = unitService.GetUnits();
            UnitsListBox.DisplayMember = "Name";
            UnitsListBox.ValueMember = "Id";

        }
        private void GenerateCode()
        {
            if (string.IsNullOrEmpty(ItemNameTextBox.Text))
            {
                return;
            }
            StringBuilder ItemCode = new StringBuilder();

            ItemCode.Append(ItemNameTextBox.Text.ToLower().Replace(" ", "-"));
            ItemCode.Append("-");
            if (ItemWarehouse.SelectedItem is Warehouse selectedWarehouse)
            {
                ItemCode.Append(selectedWarehouse.Name);
            }
            ItemCodeTextBox.Text = ItemCode.ToString();
        }

        private void LoadItems()
        {
            StockService stockService = new StockService();
            ItemsView.DataSource = stockService.GetStocks();

        }
        private void ItemsController_Load(object sender, EventArgs e)
        {
            ReloadUnits();
            LoadWarehouses();
            LoadItems();
        }

        private void CreateNewUnitButton_Click(object sender, EventArgs e)
        {
            CreateUnit createUnit = new CreateUnit();
            var result = createUnit.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReloadUnits();

            }
        }

        private void CreateItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = ItemCodeTextBox.Text;
                string Name = ItemNameTextBox.Text;

                int Quantity = int.Parse(ItemQunatityTextBox.Text);
                int Price = int.Parse(ItemPriceTextBox.Text);


                if (string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Name) ||
                    UnitsListBox.SelectedItem == null ||
                    ItemWarehouse.SelectedItem == null

                    )
                {
                    throw new Exception("Please fill all fields");
                }

                int[] UnitIds = UnitsListBox.CheckedItems.Cast<Unit>().Select((unit) => unit.Id).ToArray();

                if (UnitIds.Length == 0)
                {
                    throw new Exception("Please select at least one unit -_-");
                }

                int WarehouseId = ((Warehouse)ItemWarehouse.SelectedItem).Id;

                StockService itemService = new StockService();
                itemService.CreateNewStock(Name, Code, Quantity, Price, UnitIds, WarehouseId);
                Alerts.ShowSuccess("Item created successfully");
                LoadItems();

            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);

            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemNameTextBox.Text))
            {
                CreateItemButton.Enabled = false;
                ItemCodeTextBox.Text = "";
            }
            else
            {
                GenerateCode();
                CreateItemButton.Enabled = true;

            }
        }

        private void ItemWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateCode();
        }

        private void ItemQunatityTextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ItemQunatityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ItemQunatityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadItems();

        }
    }
}
