using System.Text.Json;
using RepairShopv2Model;

namespace RepairShopv2DL
{
    // This class is responsible for storing and reading data
    public class LocationRepo : IRepository<Locations>
    {
        private string _filepath = "../RepairShopv2DL/Data/Locations.json";

        public void Add(Locations p_Locations)
        {
            throw new NotImplementedException();
        }

        public List<Locations> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Locations> listofLocations = JsonSerializer.Deserialize<List<Locations>>(jsonString);

            return listofLocations;
        }

        public void Update(Locations p_resource)
        {
            throw new NotImplementedException();
        }
    }
}    