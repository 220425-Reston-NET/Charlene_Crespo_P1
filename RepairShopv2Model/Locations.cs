namespace RepairShopv2Model
{
    public class Locations
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public List<Order> Order { get; set; }
        public List<Products> Products { get; set; }

        // Everytime you make a new model, Make sure you create a constructor
        public Locations()
        {
            StoreID = 0;
            Name = "Default";
        }
    } 
}