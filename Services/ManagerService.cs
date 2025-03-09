using StockPulse.Models;

namespace StockPulse.Services
{
    class ManagerService
    {
        public List<Manager> GetManagers()
        {
            using (var db = new Database())
            {
                var managers = db.Managers.ToList();
                return managers;
            }
        }

        public Manager CreateManager(string name)
        {
            using (var db = new Database())
            {
                Manager manager = new Manager
                {
                    Name = name
                };
                db.Managers.Add(manager);
                db.SaveChanges();
                return manager;
            }
        }
    }
}
