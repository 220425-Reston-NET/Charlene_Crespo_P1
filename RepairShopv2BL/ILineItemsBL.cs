using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface ILineItemsBL
    {
        /// <summary>
        /// Add LineItem
        /// </summary>
        /// <param name="p_Order"> This will add a line item to order from DB</param>
        /// <returns> adds line item to DB</returns>
        void AddLineItem(LineItems p_line);



        /// <summary>
        /// See all lineitems
        /// </summary>
        /// <param name="p_line">This is the lineitem object that will display from the database</param>
        /// <returns>Gives back all lineitems from the DB</returns>
        List<LineItems> GetAll();


        /// <summary>
        /// This will search Lineitems in the DB by Description
        /// </summary>
        /// <param name="p_DESC">Description of LineItem used to search </param>
        /// <returns>Multiple Lineitems if they have matching OrderID </returns>
        LineItems SearchLineItemsByDescription(string p_DESC);


         
    }
}