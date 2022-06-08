namespace RepairShopv2Model
{

    public class Order
    {
        public int OrderID { get; set; }
        public int CustID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<LineItems> LineItems { get; set; }
public Order()
        {
           OrderID = 0;
           CustID = 0;
           TotalPrice = 0;
           LineItems = new List<LineItems>();
        }
    }
}