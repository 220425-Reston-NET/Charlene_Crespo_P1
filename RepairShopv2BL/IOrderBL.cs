using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface IOrderBL
    {

        // Will give you all of the Order from DB
        List<Order> GetAllOrders();
        
        // Will add Order to DB
       void AddOrder(List<Order> p_order);

        //Will Find Order based on name
        Order SearchOrderByName(string p_OrderName);
    }
}