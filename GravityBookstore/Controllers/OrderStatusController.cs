using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderStatusController : Controller
{
    private readonly IOrderStatusService _orderStatusService;

    public OrderStatusController(IOrderStatusService orderStatusService)
    {
        _orderStatusService = orderStatusService;
    }

    [HttpGet]
    public async Task<ActionResult<List<OrderStatusDto>>> Get([FromQuery] int id)
    {
        List<OrderStatusDto> result = await _orderStatusService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
