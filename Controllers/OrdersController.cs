using Microsoft.AspNetCore.Mvc;
using Orders.Domain.Services;
using Orders.DTOs.Request;
using Orders.DTOs.Response;

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

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var id = await _service.IniateOrder();
            var url = new Uri("https://localhost:7051/api/Orders/" + id);

            return Created(url, id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ListOrdersRequest request)
        {
            return Ok(await _service.GetAllOrders(request));
        }

        [HttpGet("summary/{id}")]
        public async Task<ActionResult<SummarizeOrderResponse>> Totalize([FromRoute] int id)
        {
            var response = await _service.CalculateTotalAmount(id);

            return Ok(new SummarizeOrderResponse(response));
        }
    }
}
