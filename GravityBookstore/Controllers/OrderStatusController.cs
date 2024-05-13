using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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
    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] OrderStatusPostDto  orderStatus)
    {
        int result = await _orderStatusService.Post(orderStatus);
        return Ok(result);
    }
}
