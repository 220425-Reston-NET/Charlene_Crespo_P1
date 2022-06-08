using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface IOrderBL
    {

        // Will give you all of the Order from DB
        List<Order> GetAllOrders();
        
        //Will Find Order based on name
        Order SearchOrderByStoreID(int p_StoreID);

        // Will add Order to DB
        void Add(Order p_order);
        // void AddOrder(List<Order> order);
    }
}