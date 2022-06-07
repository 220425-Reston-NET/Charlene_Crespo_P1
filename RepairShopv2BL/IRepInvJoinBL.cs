namespace RepairShopv2BL
{

    public interface IRepInvJoinBL
    {
        /// <summary>
        /// This will replenish inventory
        /// </summary>
        /// <param name="p_QTY">This is the quanity amount that will be replenished</param>
        /// <param name="p_ProdID">This is the product ID that will get replenished</param>
        /// <param name="p_StoreID">This is the location where the product from inventory will be replenished</param>
       void ReplenishInventory (int p_QTY, int p_ProdID, int p_StoreID);

    }

    
}