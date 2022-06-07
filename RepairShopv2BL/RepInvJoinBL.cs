using RepairShopv2DL;
using RepairShopv2Model;

namespace RepairShopv2BL
{
    public class RepInvJoinBL : IRepInvJoinBL
    {
        //========================================
        private IRepository<ProdInventoryJoin> _prodinvRepo;
        public RepInvJoinBL(IRepository<ProdInventoryJoin> p_prodinvRepo)
        {
            _prodinvRepo = p_prodinvRepo;
        }
        //=======================================

        public void ReplenishInventory(int p_QTY, int p_ProdID, int p_StoreID)
        {
             ProdInventoryJoin joinTable = new ProdInventoryJoin();
            joinTable.QTY = p_QTY;
            joinTable.ProdID = p_ProdID;
            joinTable.StoreID = p_StoreID;

            //Logic to check if the pokemon even exist

            _prodinvRepo.Update(joinTable);
        }
    }
}