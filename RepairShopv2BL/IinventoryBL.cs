using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface IinventoryBL
    {
        /// <summary>
        /// Replenish inventory in the database
        /// </summary>
        /// <param name="p_replenish">This is the replenish object that will be added to the database</param>
        /// <returns>Gives back the inventoryaa that gets added to the DB</returns>
        void ReplenishInventory(Inventory p_inventory);

        List<Inventory> GetAll();


        /// <summary>
        /// This will search Inventory in the DB by Part Name
        /// </summary>
        /// <param name="p_PartName">Name of Parts used to search </param>
        /// <returns>Multiple parts if they have matching names </returns>
        Inventory SearchInventoryByPartName(string p_PartName);
    }
}