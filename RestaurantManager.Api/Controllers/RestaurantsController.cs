using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult ListRestaurant()
        {
            return Ok(Array.Empty<string>());
        }
    }
}
