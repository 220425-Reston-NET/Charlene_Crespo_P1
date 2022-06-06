namespace RepairShopv2Model
{

    public class Order
    {
        private int _OrderID;
        public int OrderID
        {
            get { return _OrderID; }

            set
            {
                if (value > 0)
                {
                    _OrderID = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        
        }

        private int _CustID;
        public int CustID
        {
            get { return CustID; }
            set 
            { 
                if (value > 0)
                {
                    _CustID = value; 
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        private int _StoreID;
        public int StoreID
        {
            get { return _StoreID; }

            set
            {
                if (value > 0)
                {
                    _StoreID = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        private float _TotalPrice;
        public float TotalPrice
        {
            get { return _TotalPrice; }
            set 
            {
                if (value > 0)
                {
                  _TotalPrice = value; 

                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        
        public List<LineItems> LineItems { get; set; }
public Order()
        {
           OrderID = 1;
           CustID = 1;
           StoreID = 100;
           TotalPrice = 200.00F;
           LineItems = new List<LineItems>();
        }

        public override string ToString()
        {
            return $"=====Order Info=====\nOrderID: {OrderID}\nCustID: {CustID}\nStoreID: {StoreID}\nTotalPrice: {TotalPrice}\n=========";
        }

        public static List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public static List<Locations> GetAllLocations()
        {
            throw new NotImplementedException();
        }
    }
}