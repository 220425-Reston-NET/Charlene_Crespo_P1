namespace RepairShopv2Model
{
    public class LineItems
    {
       public int OrderID { get; set; }
       public int ProdID { get; set; }
       public int QTY { get; set; }
    
        // Everytime you make a new model, Make sure you create a constructor
        public LineItems()
        {
            OrderID = 0;
            ProdID = 0;
            QTY = 0;
        }
    } 
}