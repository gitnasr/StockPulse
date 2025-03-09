using StockPulse.Services;

namespace StockPulse.Dialog
{
    public partial class CreateUnit : Form
    {
        private readonly UnitService unitService = new UnitService();
        public CreateUnit()
        {
            InitializeComponent();
        }

        private void CreateUnitButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(UnitNameTextBox.Text))
                {
                    throw new("Please enter a unit name");
                }


                unitService.CreateUnit(UnitNameTextBox.Text);
                DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CancelUnitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
