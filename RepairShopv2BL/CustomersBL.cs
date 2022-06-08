using RepairShopv2Model;
using RepairShopv2DL;

namespace RepairShopv2BL
{

    public class CustomersBL : ICustomersBL
    {
        //================== Dependency Injection ====================
        private IRepository<Customers> _CustRepo;
        public CustomersBL(IRepository<Customers> p_CustRepo)
        {
            _CustRepo = p_CustRepo;
        }

        public void AddCustomer(Customers p_cust)
        {
            Customers foundedcustomer = SearchCustomerByName(p_cust.Name);
            if (foundedcustomer == null)
            {
                _CustRepo.Add(p_cust);
            }
            else 
            {
                throw new Exception("Customer name already exists");
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return _CustRepo.GetAll();
        }

        public Customers SearchCustomerByName(string p_Name)
        {
            List<Customers> currentListofCust =  _CustRepo.GetAll();
            
            foreach (Customers CustObj in currentListofCust)
            {
                if (CustObj.Name == p_Name)
                {
                    return CustObj;
                }
            }

            return null;
        }

        public Customers SearchCustomerByNumber(long p_Number)
        {
            List<Customers> currentListofCust = _CustRepo.GetAll();

            foreach (Customers CustObj in currentListofCust)
            {
                if (CustObj.Number == p_Number)
                {
                    return CustObj;
                }
            }

            return null;
        }
    }
}