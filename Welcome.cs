using StockPulse.GUI;
using StockPulse.Views;

namespace StockPulse
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SidebarSelection(new WarehouseController(), WarehouseButton);
            StatusBarManager.UpdateStatus("Welcome to StockPulse");

        }
        private void SidebarSelection(UserControl selectedControl, Button clickedButton)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(selectedControl);

            foreach (Control ctrl in SidePanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = true;
                }
            }
            clickedButton.Enabled = false;

            int currentHeightOfSidePanel = SidePanel.Height;

            Size = new Size(selectedControl.Width + SidePanel.Width + 15, selectedControl.Height + StatusBarManager.Height + 150);
            MainPanel.Controls.Add(StatusBarManager.NewStatusBar.StatusBar);

        }

        private void WarehouseButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SidebarSelection(new WarehouseController(), clickedButton);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SidebarSelection(new ItemsController(), clickedButton);
            }
        }

        private void SupplyPremitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SidebarSelection(new SupplyPremitController(), clickedButton);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SidebarSelection(new DisposePremit(), clickedButton);
            }
        }
    }
}
