using Microsoft.AspNetCore.Mvc;
using orderService.Model;

namespace orderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {

        [HttpGet("Getorders")]
        public IActionResult Getorders()
        {
            var orders = OrderData.Instance.orders;
            return Ok(orders);
        }
    }
}