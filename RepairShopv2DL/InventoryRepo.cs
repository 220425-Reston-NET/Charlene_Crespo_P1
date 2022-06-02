using System.Text.Json;
using RepairShopv2Model;

namespace RepairShopv2DL
{
    // This class is responsible for storing and reading data
    public class InventoryRepo : IRepository<Inventory>
    {
        private string _filepath = "../RepairShopv2DL/Data/Inventorty.json";

        public void Add(Inventory p_inventory)
        {
            List<Inventory> listofInventory = GetAll();
            listofInventory.Add(p_inventory);

            string jsonString = JsonSerializer.Serialize(listofInventory, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<Inventory> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Inventory> listofInventory = JsonSerializer.Deserialize<List<Inventory>>(jsonString);

            return listofInventory;
        }
        public void Update(Inventory p_resource)
        {
            throw new NotImplementedException();
        }
    }
}