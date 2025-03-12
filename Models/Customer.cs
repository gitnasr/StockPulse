namespace StockPulse.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }


        public ICollection<DisposePremit> DisposePremits { get; set; } = new List<DisposePremit>();


        public override string ToString()
        {
            return Name;
        }



    }
}
