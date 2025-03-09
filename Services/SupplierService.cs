using StockPulse.Models;

namespace StockPulse.Services
{
    public class SupplierService
    {
        public void CreateSupplier(string Name, string Phone, string Fax, string Email, string Website)
        {

            using (var db = new Database())
            {

                var Supplier = new Supplier()
                {
                    Name = Name,
                    Phone = Phone,
                    Fax = Fax,
                    Email = Email,
                    Website = Website
                };

                db.Add(Supplier);
                db.SaveChanges();

            }

        }
        public List<Supplier> GetAllSuppliers()
        {

            using (var db = new Database())
            {

                return db.Suppliers.ToList();

            }

        }
    }
}
