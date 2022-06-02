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

        public OrdersController(IOrderBL OrderBL)
        {
            _orderBL = OrderBL;
        }

        //=================================================
        [HttpGet("GetAllOrders")]
        public IActionResult GetAll()
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

        [HttpGet("SearchOrdersByName")]
        public IActionResult SearchOrders([FromQuery] string OrderName)
        {
            try
            {
                return Ok(_orderBL.SearchOrderByName(OrderName));
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    }
}
