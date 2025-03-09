using StockPulse.GUI;
using StockPulse.Models;
using StockPulse.Services;

namespace StockPulse
{
    public partial class WarehouseController : UserControl
    {
        private readonly WarehouseService WarehouseService = new WarehouseService();
        private readonly ManagerService ManagerService = new ManagerService();
        private readonly ContextMenuStrip ContextMenu = new ContextMenuStrip();
        private void LoadWarehouseContextMenu()
        {
            ContextMenu.Items.Add("Edit", null, EditWarehouse);
        }



        private void EditWarehouse(object? sender, EventArgs e)
        {
            if (WarehouseTableView.SelectedRows.Count == 0)
            {
                Alerts.ShowError("Please select a warehouse to edit");
                return;
            }
            int WarehouseId = (int)WarehouseTableView.SelectedRows[0].Cells["Id"].Value!;
            Warehouse warehouse = WarehouseService.GetWarehouseById(WarehouseId);
            WarehouseNameTextBox.Text = warehouse.Name;
            WarehouseAddressTextbox.Text = warehouse.Address;
            ChooseManagerCombobox.SelectedValue = warehouse.Manager.Id;
            CreateUpdateWarehouseButton.Text = "Update Warehouse";
            CreateUpdateWarehouseButton.Click -= CreateWarehouseButton_Click;
            CreateUpdateWarehouseButton.Click -= UpdateWarehouseButton_Click;
            CreateUpdateWarehouseButton.Click += UpdateWarehouseButton_Click;



        }
        public WarehouseController()
        {
            InitializeComponent();
            LoadWarehouseContextMenu();
        }
        private void ToggleControls(string? Status = null)
        {

            StatusBarManager.UpdateStatus(Status);

            foreach (Control control in this.Controls)
            {
                if (Status == null)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = !control.Enabled;
                }

            }

        }
        private void LoadManagers()
        {
            ChooseManagerCombobox.SelectedIndex = 0;
            List<Manager> managers = ManagerService.GetManagers();
            managers.Insert(0, new Manager { Id = -1, Name = "Choose a Manager" });

            ChooseManagerCombobox.DataSource = managers;
            ChooseManagerCombobox.DisplayMember = "Name";
            ChooseManagerCombobox.ValueMember = "Id";
        }

        private void LoadWarehouses()
        {
            List<Warehouse> warehouses = WarehouseService.GetWarehousesWithManager();
            WarehouseTableView.DataSource = warehouses;
            WarehouseTableView.Columns["Id"].Visible = false;
            WarehouseTableView.AutoResizeColumns();
            WarehouseTableView.ContextMenuStrip = ContextMenu;
        }

        private void WarehouseController_Load(object sender, EventArgs e)
        {
            LoadManagers();
            LoadWarehouses();

        }

        private void ChooseManagerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseManagerCombobox.SelectedIndex != 0)
            {
                CreateUpdateWarehouseButton.Enabled = true;
            }
            else
            {
                CreateUpdateWarehouseButton.Enabled = false;

            }
        }

        private void UpdateWarehouseButton_Click(object? sender, EventArgs e)
        {
            ToggleControls("Updating a Warehouse ...");

            try
            {
                string WarehouseName = WarehouseNameTextBox.Text;
                string WarehouseAddress = WarehouseAddressTextbox.Text;
                int ManagerId = (int)ChooseManagerCombobox.SelectedValue!;
                if (string.IsNullOrWhiteSpace(WarehouseName) || string.IsNullOrWhiteSpace(WarehouseAddress))
                {
                    throw new Exception("Warehouse name and address cannot be empty");
                }
                if (ManagerId == -1)
                {
                    throw new Exception("Please choose a manager");
                }
                if (WarehouseTableView.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a warehouse to update");
                }
                int SelectedWarehouseID = (int)WarehouseTableView.SelectedRows[0].Cells["Id"].Value!;
                WarehouseService.UpdateWarehouseById(SelectedWarehouseID, WarehouseName, WarehouseAddress, ManagerId);
                ResetAndLoadWarehouses();
                ToggleControls("Warehouse updated successfully");

            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);
            }
            finally
            {
                ToggleControls();
            }
        }
        private void CreateWarehouseButton_Click(object? sender, EventArgs e)
        {
            try
            {
                ToggleControls("Created a Warehouse .....");

                string WarehouseName = WarehouseNameTextBox.Text;
                string WarehouseAddress = WarehouseAddressTextbox.Text;
                int ManagerId = (int)ChooseManagerCombobox.SelectedValue!;
                if (string.IsNullOrWhiteSpace(WarehouseName) || string.IsNullOrWhiteSpace(WarehouseAddress))
                {
                    throw new Exception("Warehouse name and address cannot be empty");
                }
                if (ManagerId == -1)
                {
                    throw new Exception("Please choose a manager");
                }
                WarehouseService.CreateWarehouse(WarehouseName, WarehouseAddress, ManagerId);
                ResetAndLoadWarehouses();
                ToggleControls("Created a Warehouse Successfully");
            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);
            }
            finally
            {
                ToggleControls();
            }
        }

        private void CreateManagerButton_Click(object sender, EventArgs e)
        {
            ToggleControls("Creating a Manager ...");

            try
            {
                if (string.IsNullOrWhiteSpace(ManagerNameTextbox.Text) || ManagerNameTextbox.Text.All(char.IsDigit))
                {
                    throw new Exception("Manager name cannot be empty or a number");
                }

                Manager manager = ManagerService.CreateManager(ManagerNameTextbox.Text);
                if (manager == null)
                {
                    throw new Exception("Manager creation failed");
                }
                ManagerNameTextbox.Text = string.Empty;
                ToggleControls("Manager created successfully");
                LoadManagers();
            }
            catch (Exception ex)
            {
                Alerts.ShowError(ex.Message);
            }
            finally
            {

                ToggleControls();

            }

        }


        private void ResetAndLoadWarehouses()
        {
            WarehouseNameTextBox.Text = string.Empty;
            WarehouseAddressTextbox.Text = string.Empty;
            ChooseManagerCombobox.SelectedIndex = 0;

            CreateUpdateWarehouseButton.Text = "Create Warehouse";

            CreateUpdateWarehouseButton.Click -= CreateWarehouseButton_Click;
            CreateUpdateWarehouseButton.Click -= UpdateWarehouseButton_Click;

            CreateUpdateWarehouseButton.Click += CreateWarehouseButton_Click;

            LoadWarehouses();
        }

    }
}
