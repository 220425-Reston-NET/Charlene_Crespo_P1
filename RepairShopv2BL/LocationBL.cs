using RepairShopv2DL;
using RepairShopv2Model;

namespace RepairShopv2BL
{
    public class LocationBL : ILocationBL
    {

        //================== Dependency Injection ====================
        private IRepository<Locations> _LocationRepo;
        public LocationBL(IRepository<Locations> p_LocationRepo)
        {
            _LocationRepo = p_LocationRepo;
        }
        public List<Locations> GetAll()
        {
            return _LocationRepo.GetAll();
        }

        public void ReplenishInventory(int invenReplenish)
        {
            throw new NotImplementedException();
        }

        public Locations SearchLocationsByName(string p_Name)
        {
            List<Locations> listofLocations =  _LocationRepo.GetAll();
            
            foreach (Locations LocObj in listofLocations)
            {
                if (LocObj.Name == p_Name)
                {
                    return LocObj;
                }
            }

            return null;
        }

        public Locations ViewLocationInventory(Locations p_Locations)
        {
            throw new NotImplementedException();
        }
    }
}