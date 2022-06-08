using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface ILocationBL
    {
      /// <summary>
      /// Will Display the list of products from a store
      /// </summary>
      /// <param name="StoreID">This is the store it will select</param>
      /// <returns>Gives a list of products from that store</returns>
       public List<Products> ViewLocationInventory(int StoreID);

    }
}