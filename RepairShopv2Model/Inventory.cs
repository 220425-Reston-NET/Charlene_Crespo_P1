namespace RepairShopv2Model
{
    public class Inventory
    {

      public int StoreID { get; set; }
      public int ProdID { get; set; }
      public int QTY { get; set; }
      public List<Products> Products { get; set; }
      public List<Locations> Locations { get; set; }
    
        // Everytime you make a new model, Make sure you create a constructor
        public Inventory()
        {
            StoreID = 0;
            ProdID = 0;
            QTY = 0;
        }
    } 
}