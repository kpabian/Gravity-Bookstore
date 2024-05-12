using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderLineController : Controller
{
    private readonly IOrderLineService _orderLineService;

    public OrderLineController(IOrderLineService orderLineService)
    {
        _orderLineService = orderLineService;
    }

    [HttpGet]
    public async Task<ActionResult<List<OrderLineDto>>> Get([FromQuery] int id)
    {
        List<OrderLineDto> result = await _orderLineService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
