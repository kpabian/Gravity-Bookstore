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
    public async Task<ActionResult<int>> Post([FromBody] OrderStatusPostDto orderStatus)
    {
        int result = await _orderStatusService.Post(orderStatus);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] OrderStatusPostDto orderStatus)
    {
        bool result = await _orderStatusService.Put(orderStatus, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _orderStatusService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
