using Microsoft.EntityFrameworkCore;
using StockPulse.Models;

namespace StockPulse.Services
{
    public class DisposePremitService
    {
        public void Create(int supplierId, int[] itemsIds, int CustomerId)
        {



            using (var db = new Database())
            {
                List<Stock> items = db.Stocks.Where(stock => itemsIds.Contains(stock.Id)).ToList();
                var DisposePremit = new DisposePremit
                {
                    SupplierId = supplierId,
                    Stocks = items,
                    CustomerId = CustomerId
                };
                db.Add(DisposePremit);

                items.ForEach(stock =>
                {
                    stock.Quantity -= 1;
                });
                db.Stocks.UpdateRange(items);



                db.SaveChanges();
            }
        }

        public List<DisposePremit> GetAllDisposePremits()
        {
            using (var db = new Database())
            {
                return db.DisposePremits.Include(disposePremit => disposePremit.Customer)
                    .Include(disposePremit => disposePremit.Supplier).ToList();
            }
        }
    }
}
