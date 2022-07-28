using System.ComponentModel.DataAnnotations;

namespace RepairShopv2Model
{
    public class Customers
    {
        public int CustID { get; set; }
        public string Name { get; set; }

        private long _Number;
        public long Number
        {
            get { return _Number; }
            set
            {
                if (value > 999999999)
                {
                    _Number = value;
                }
                else
                {
                    throw new ValidationException("Number needs to be 10 digits");
                }
            }
        }

        public string Address { get; set; }
        public String Email { get; set; }
        public List<Order> Order { get; set; }

        // Everytime you make a new model, Make sure you create a constructor
        public Customers()
        {
            CustID = 0;
            Number = 8887776666;
            Name = "Default";
            Address = "Default";
            Email = "Default";
            Order = new List<Order>();
        }
    } 
}
