using StockPulse.GUI;

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
            MainPanel.Controls.Add(StatusBarManager.NewStatusBar.StatusBar);
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

        }

        private void WarehouseButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SidebarSelection(new WarehouseController(), clickedButton);
            }
        }
    }
}
