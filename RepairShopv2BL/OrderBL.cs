using RepairShopv2DL;
using RepairShopv2Model;

namespace RepairShopv2BL
{
    public class OrderBL : IOrderBL
    {
        //====Dependency Injection====
        private IRepository<Order> _OrderRepo;
        public OrderBL(IRepository<Order> p_OrderRepo)
        {
            _OrderRepo = p_OrderRepo;
        }

        public void AddOrder(List<Order> p_order)
        {
           foreach (Order item in p_order)
           {
               _OrderRepo.Add(item);
           }
            
        }
    

        //===========================

        public List<Order> GetAllOrders()
        {
            return _OrderRepo.GetAll();
        }

        public Order SearchOrderByID(int p_OrderID)
        {
            List<Order> currentListOfOrder = _OrderRepo.GetAll();

            foreach (Order OrderObj in currentListOfOrder)
            {
                if (OrderObj.OrderID == p_OrderID)
                {
                    return OrderObj;
                }
            }

            return null;
        }

        public Order SearchOrderByName(string p_OrderName)
        {
            throw new NotImplementedException();
        }
    }
}