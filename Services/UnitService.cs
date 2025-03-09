using StockPulse.Models;

namespace StockPulse.Services
{
    class UnitService
    {
        public List<Unit> GetUnits()
        {
            using (var db = new Database())
            {
                var units = db.Units.ToList();
                return units;
            }
        }

        public Unit CreateUnit(string name)
        {
            using (var db = new Database())
            {
                Unit unit = new Unit
                {
                    Name = name
                };
                db.Units.Add(unit);
                db.SaveChanges();
                return unit;
            }
        }
    }
}
