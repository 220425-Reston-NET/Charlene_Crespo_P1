using RepairShopv2DL;
using RepairShopv2Model;

namespace RepairShopv2BL
{

    public class LineItemsBL : ILineItemsBL
    {
        //================== Dependency Injection ====================
        private IRepository<LineItems> _LineItemsRepo;
        public LineItemsBL(IRepository<LineItems> p_LineItemsRepo)
        {
            _LineItemsRepo = p_LineItemsRepo;
        }
        public void AddLineItem(LineItems p_line)
        {
           _LineItemsRepo.Add(p_line);
        }

        public List<LineItems> GetAll()
        {
            return _LineItemsRepo.GetAll();
        }

        public LineItems SearchLineItemsByDescription(string p_DESC)
        {
            throw new NotImplementedException();
        }
    }
}