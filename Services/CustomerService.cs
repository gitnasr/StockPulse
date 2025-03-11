using StockPulse.Models;

namespace StockPulse.Services
{
    public class CustomerService
    {

        public void AddCustomer()
        {
            throw new NotImplementedException();
        }
        public void UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(Customer Customer)
        {

            using (var db = new Database())
            {
                db.Customer.Add(Customer);
                db.SaveChanges();
            }

        }

        public List<Customer> GetCustomers()
        {
            using (var db = new Database())
            {
                return db.Customer.ToList();
            }
        }
    }
}
