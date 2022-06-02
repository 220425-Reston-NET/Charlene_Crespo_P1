namespace RepairShopv2Model
{
    public class Inventory
    {

        private int _Price;
        public int Price
        {
            get { return _Price; }
            set
            {
                if (value > 0)
                {
                    _Price = value;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
            
            private int _PartID;
            public int PartID
            {
                get { return _PartID; }
                set 
                { 
                    if (value > 0)
                    {
                        _PartID = value;
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }

            private int _Quantity;
            public int Quantity
            {
                get { return _Quantity; }
                set 
                { 
                    if (value > 0)
                    {
                        _Quantity = value; 
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            
            
        

        public string LocationName { get; set; }
        public string PartName { get; set; }
    
        // Everytime you make a new model, Make sure you create a constructor
        public Inventory()
        {
            LocationName = "RepairShop1";
            PartID = 1;
            PartName = "Iphone 13 Max LCD Screen";
            Quantity = 50;
            Price = 200;
        }

        public override string ToString()
        {
            return $"=====Inventory Info=====\nLocationName: {LocationName}\nPartID: {PartID}\nPartName {PartName}\nQuantity {Quantity}\nPrice {Price}\n=========";
        }

        public static List<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }
    } 
}