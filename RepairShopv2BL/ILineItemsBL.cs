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

        public List<LineItems> GetAllLineItems();
    }
}