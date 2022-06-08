using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepairShopv2BL;
using RepairShopv2Model;

namespace RepairShopv2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineItemsController : ControllerBase
    {
         //=================Dependency Injection=============
        private ILineItemsBL _lineItemsBL;

        public LineItemsController(ILineItemsBL LineItemsBL)
        {
            _lineItemsBL = LineItemsBL;

        }

        //================================================

        [HttpPost("AddLineItem")]

        public IActionResult AddLineItems([FromBody] LineItems p_line)
        {
           try
            {
                _lineItemsBL.AddLineItem(p_line);
               

                return Created("LineItems have been added", p_line);
                
            
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("LineItemList")]

        public IActionResult ListofLineItems()
        {

            try
            {
                List<LineItems> listOflineitems = _lineItemsBL.GetAllLineItems();
    
                //Followed by "Ok()" it determines what http status code to give
                return Ok(listOflineitems);
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}