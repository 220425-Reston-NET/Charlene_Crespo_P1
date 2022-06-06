namespace RepairShopv2Model
{
    public class Locations
    {

        private int _Zip;
        public int Zip
        {
            get { return _Zip; }
            set
            {
                if (value > 0)
                {
                    _Zip = value;
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
            get { return StoreID; }
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
        

        public string Name { get; set; }
        public string Address { get; set; }
        public String City { get; set; }
        public string State { get; set; }
        public List<Order> Order { get; set; }
        public List<Products> Products { get; set; }

        // Everytime you make a new model, Make sure you create a constructor
        public Locations()
        {
            StoreID = 100;
            Name = "RepairShop1";
            Address = "123 crandon ave";
            City = "Miami";
            State = "FL";
            Zip = 33196;
            Order = new List<Order>();
        }

        public override string ToString()
        {
            return $"=====Locations Info=====\nStoreID: {StoreID}\nName: {Name}\nAddress: {Address}\nCity {City}\nState {State}\nZip {Zip}\n=========";
        }

        public static List<Locations> GetAll()
        {
            throw new NotImplementedException();
        }

        public static List<Products> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    } 
}