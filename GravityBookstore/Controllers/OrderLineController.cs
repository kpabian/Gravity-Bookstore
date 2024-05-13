using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] OrderLinePostDto orderLine)
    {
        int result = await _orderLineService.Post(orderLine);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] OrderLinePostDto orderLine)
    {
        bool result = await _orderLineService.Put(orderLine, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _orderLineService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
