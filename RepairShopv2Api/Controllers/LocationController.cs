using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RepairShopv2BL;
using RepairShopv2Model;

namespace RepairShopv2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private ILocationBL _locationBL;
        public LocationController(ILocationBL p_locationBL)
        {
            _locationBL = p_locationBL;
        }

        [HttpGet("ViewStoreInventory")]

        public IActionResult ViewStoreInventory([FromQuery] int p_StoreID)
            {
                return Ok(_locationBL.ViewLocationInventory(p_StoreID));
            }
    }

}