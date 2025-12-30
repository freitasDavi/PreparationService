using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public IActionResult Create()
        {
            return Created();
        }

        public IActionResult GetAll()
        {
            return Ok();
        }

        public IActionResult Totalize()
        {
            return Ok();
        }
    }
}
