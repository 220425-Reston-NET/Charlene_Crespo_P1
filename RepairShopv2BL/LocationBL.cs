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
        public List<Products> ViewLocationInventory(int p_StoreID)
        {
            List<Locations> listofLocations = _LocationRepo.GetAll();

            foreach (Locations item in listofLocations)
            {
                if (item.StoreID == p_StoreID)
                {
                    return item.Products;
                }
            }
            return null;
        }
    }
}