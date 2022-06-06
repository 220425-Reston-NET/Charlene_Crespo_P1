namespace RepairShopv2Model
{
    public class Products
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

            private int _AMT;
            public int AMT
            {
                get { return _AMT; }
                set 
                { 
                    if (value > 0)
                    {
                        _AMT = value; 
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
             public string Description { get; set; }
    
        // Everytime you make a new model, Make sure you create a constructor
        public Products()
        {
            ProdID = 010;
            StoreID = 100;
            Description = "Iphone 13 Max LCD Screen Replacement";
            AMT = 200;
        }

        public override string ToString()
        {
            return $"=====Products Info=====\nProdID: {ProdID}\nStoreID: {StoreID}\nDescription: {Description}\nAMT {AMT}\n=========";
        }

        public static List<Products> GetAll()
        {
            throw new NotImplementedException();
        }
    } 
}