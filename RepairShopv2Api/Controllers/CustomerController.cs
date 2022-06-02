using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepairShopv2BL;
using RepairShopv2Model;

namespace RepairShopv2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
         //=================Dependency Injection=============
        private ICustomersBL _CustBL;
        private IOrderBL _OrderBL;

        public CustomerController(ICustomersBL CustBL, IOrderBL orderBL)
        {
            _CustBL = CustBL;
            _OrderBL = orderBL;
        }

        //=================================================
        [HttpGet("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {

            try
            {
                List<Customers> listOfCustomers = _CustBL.GetAllCustomers();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfCustomers);
            }
            catch (SqlException)
            {
                return NotFound("No Customer Exist");
            }
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customers p_cust)
        {
           try
            {
                _CustBL.AddCustomer(p_cust);
                _OrderBL.AddOrder(p_cust.Order);

                return Created("Customer was created!", p_cust);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchCustomerByName")]
        public IActionResult SearchCustomer([FromQuery] string CustName)
        {
            try
            {
                return Ok(_CustBL.SearchCustomerByName(CustName));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}
