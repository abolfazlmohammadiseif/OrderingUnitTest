using Microsoft.AspNetCore.Mvc;
using Ordering.Application.Services.Orders;

namespace Ordering.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        public IOrderService _orderService { get; set; }
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _orderService.GetAsync());
        }
    }
}
