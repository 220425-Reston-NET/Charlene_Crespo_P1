using System.Text.Json;
using RepairShopv2Model;

namespace RepairShopv2DL
{
    // This class is responsible for storing and reading data
    public class CustRepo : IRepository<Customers>
    {
        private string _filepath = "../RepairShopv2DL/Data/Customers.json";

        public void Add(Customers p_cust)
        {
            List<Customers> listofcust = GetAll();
            listofcust.Add(p_cust);

            string jsonString = JsonSerializer.Serialize(listofcust, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<Customers> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Customers> listofCustomers = JsonSerializer.Deserialize<List<Customers>>(jsonString);

            return listofCustomers;
        }

        public void Update(Customers p_resource)
        {
            List<Customers> listofCustomers = GetAll();

            foreach (Customers CustObj in listofCustomers)
            {
                if (CustObj.Name == p_resource.Name)
                {
                    CustObj.Order = p_resource.Order;
                }
            }

            string jsonString = JsonSerializer.Serialize(listofCustomers, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }
    }
}


