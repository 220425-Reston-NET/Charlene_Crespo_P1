namespace RepairShopv2Model
{
    public class Customers
    {

        private long _Number;
        public long Number
        {
            get { return _Number; }
            set
            {
                if (value > 0)
                {
                    _Number = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public String Email { get; set; }
        public List<Order> Order { get; set; }

        // Everytime you make a new model, Make sure you create a constructor
        public Customers()
        {
            Number = 7869083474;
            Name = "Charlene";
            Address = "so long ave";
            Email = "char@code.com";
            Order = new List<Order>();
        }

        public override string ToString()
        {
            return $"=====Customer Info=====\nNumber: {Number}\nName: {Name}\nAddress {Address}\nEmail {Email}\n=========";
        }

        public static List<Order> GetAll()
        {
            throw new NotImplementedException();
        }
    } 
}