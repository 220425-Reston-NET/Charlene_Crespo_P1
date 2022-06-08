namespace RepairShopv2Model
{
    public class Products
    {

        
        public int ProdID { get; set; }
        public string Description { get; set; }
        public int QTY { get; set; }
    
        public decimal Price { get; set; }
        
        // Everytime you make a new model, Make sure you create a constructor
        public Products()
        {
            ProdID = 0;
            Description = "Default";
            Price = 0;
            QTY = 0;
        }    
    } 
}