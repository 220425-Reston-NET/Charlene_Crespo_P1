using System.ComponentModel.DataAnnotations;

namespace RepairShopv2Model
{
    public class Customers
    {

        private int _CustID;
        public int CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        

        private long _Number;
        public long Number
        {
            get { return _Number; }
            set
            {
                if (Number > 10)
                {
                    _Number = Number;
                }
                else
                {
                    throw new ValidationException("Number needs to be 10 digits");
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
            CustID = 1;
            Number = 7869083474;
            Name = "Charlene";
            Address = "so long ave";
            Email = "char@code.com";
            Order = new List<Order>();
        }

        public override string ToString()
        {
            return $"=====Customer Info=====\nCustID {CustID}\nNumber: {Number}\nName: {Name}\nAddress {Address}\nEmail {Email}\n=========";
        }

        public static List<Order> GetAll()
        {
            throw new NotImplementedException();
        }
    } 
}