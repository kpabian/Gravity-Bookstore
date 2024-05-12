using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderHistoryController : Controller
{
    private readonly IOrderHistoryService _orderHistoryService;

    public OrderHistoryController(IOrderHistoryService orderHistoryService)
    {
        _orderHistoryService = orderHistoryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<OrderHistoryDto>>> Get([FromQuery] int id)
    {
        List<OrderHistoryDto> result = await _orderHistoryService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
