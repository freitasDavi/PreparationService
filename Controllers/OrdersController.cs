using Microsoft.AspNetCore.Mvc;
using Orders.Domain.Services;

namespace Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrdersController(IOrderService orderService)
        {
            _service = orderService;
        }
        public IActionResult Create()
        {
            return Created();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllOrders());
        }

        public IActionResult Totalize()
        {
            return Ok();
        }
    }
}
