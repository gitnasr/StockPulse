using Microsoft.EntityFrameworkCore;
using StockPulse.Models;

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
            using (var db_context = new Database())
            {
                // 1. Create a Manager
                Manager m1 = new Manager();
                m1.Name = "Mahmoud Nasr";


                var insertedManager = db_context.Add(m1);


                db_context.SaveChanges();
                //2. Create a Warehouse

                Warehouse w1 = new Warehouse();

                w1.manager = m1;
                w1.Address = "Semouha, Alexandria";


                db_context.Add(w1);



                db_context.SaveChanges();

                foreach (var item in db_context.Warehouses.Include(w => w.manager))
                {
                    MessageBox.Show($"Warehouse: {item.Address} is Managed By {item.manager.Name} with an ID {item.manager.Id}");


                }


            }


        }
    }
}
