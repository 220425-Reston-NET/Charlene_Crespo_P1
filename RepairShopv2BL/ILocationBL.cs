using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface ILocationBL
    {
        /// <summary>
        /// See all locations
        /// </summary>
        /// <param name="p_loc">This is the location object that will display from the database</param>
        /// <returns>Gives back the all locations from the DB</returns>
        // void GetAllLocations(Locations p_loc);

        List<Locations> GetAll();


        /// <summary>
        /// This will search Locations in the DB by Name
        /// </summary>
        /// <param name="p_Name">Name of Location used to search </param>
        /// <returns>Multiple Locations if they have matching names </returns>
        

        Locations SearchLocationsByName(string p_Name);

        Locations ViewLocationInventory(Locations p_Locations);
        void ReplenishInventory(int invenReplenish);

    }
}