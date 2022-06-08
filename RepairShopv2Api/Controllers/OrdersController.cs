using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepairShopv2BL;
using RepairShopv2Model;

namespace RepairShopv2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
         //=================Dependency Injection=============
        private IOrderBL _orderBL;
        private ILineItemsBL _lineItemsBL;

        public OrdersController(IOrderBL OrderBL, ILineItemsBL LineItemsBL)
        {
            _orderBL = OrderBL;
            _lineItemsBL = LineItemsBL;

        }

        //=================================================
        [HttpGet("GetAllOrders")]
        public IActionResult GetAllOrders()
        {

            try
            {
                List<Order> listOfOrders = _orderBL.GetAllOrders();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOfOrders);
            }
            catch (SqlException)
            {
                return NotFound("No Order Exist");
            }
        }
    

        [HttpPost("AddOrder")]

        public IActionResult Add([FromBody] Order p_orders)
        {
           try
            {
                _orderBL.Add(p_orders);
               

                return Created("Order was created!", p_orders);
                
            
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}
