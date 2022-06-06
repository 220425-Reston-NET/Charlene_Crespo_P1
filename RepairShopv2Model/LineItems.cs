namespace RepairShopv2Model
{
    public class LineItems
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
        public LineItems()
        {
            OrderID = 1;
            ProdID = 010;
            Description = "Iphone 13 Max LCD Screen Replacement";
            QTY = 1;
            AMT = 200;
        }

        public override string ToString()
        {
            return $"=====LineItems Info=====\nOrderID: {OrderID}\nProdID: {ProdID}\nDescription: {Description}\nQTY: {QTY}\nAMT {AMT}\n=========";
        }
    } 
}