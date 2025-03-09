using StockPulse.Dialog;
using StockPulse.Services;
namespace StockPulse
{

    public partial class ItemsController : UserControl
    {
        private readonly UnitService unitService = new UnitService();
        public ItemsController()
        {
            InitializeComponent();
        }

        private void ReloadUnits()
        {
            UnitsListBox.DataSource = unitService.GetUnits();
            UnitsListBox.DisplayMember = "Name";
            UnitsListBox.ValueMember = "Id";
        }
        private void ItemsController_Load(object sender, EventArgs e)
        {
            ReloadUnits();


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
    }
}
