using System.Text.Json;
using RepairShopv2Model;

namespace RepairShopv2DL
{
    public class OrderRepo : IRepository<Order>
    {
        private string _filepath = "../RepairShopDL/Data/Order.json";
        public void Add(Order p_Order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Order> listofOrder = JsonSerializer.Deserialize<List<Order>>(jsonString);

            return listofOrder;
        }

        public void Update(Order p_resource)
        {
            throw new NotImplementedException();
        }
    }
}