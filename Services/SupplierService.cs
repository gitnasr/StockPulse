using Microsoft.EntityFrameworkCore;
using StockPulse.Models;

namespace StockPulse.Services
{
    public class SupplierService
    {

        public Supplier GetSupplierById(int id)
        {
            using (var db = new Database())
            {

                return db.Suppliers.First(supplier => supplier.Id == id);

            }
        }
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

        public List<Stock> GetItemsBySupplierId(int id)
        {

            using (var db = new Database())
            {
                var supplier = db.Suppliers.
                    Include(supplier => supplier.SupplyPremits).ThenInclude(supplyPremit => supplyPremit.Stocks).
                    First(supplier => supplier.Id == id);





                return supplier.SupplyPremits.SelectMany(supplyPremit => supplyPremit.Stocks).ToList();
            }

        }
    }
}
