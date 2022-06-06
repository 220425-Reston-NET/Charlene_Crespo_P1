namespace RepairShopv2Model
{
    public class Inventory
    {

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
            
            private int _ProdID;
            public int ProdID
            {
                get { return _ProdID; }
                set 
                { 
                    if (value > 0)
                    {
                        _ProdID = value;
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }

            private int _QTY;
            public int QTY
            {
                get { return _QTY; }
                set 
                { 
                    if (value > 0)
                    {
                        _QTY = value; 
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
             public string Description { get; set; }
             public List<Products> Products { get; set; }
             public List<Locations> Locations { get; set; }
    
        // Everytime you make a new model, Make sure you create a constructor
        public Inventory()
        {
            StoreID = 100;
            ProdID = 010;
            Description = "Iphone 13 Max LCD Screen Replacement";
            QTY = 50;
        }

        public override string ToString()
        {
            return $"=====Inventory Info=====\nStoreID: {StoreID}\nProdID: {ProdID}\nDescription: {Description}\nQTY {QTY}\n=========";
        }

        public static List<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }
    } 
}