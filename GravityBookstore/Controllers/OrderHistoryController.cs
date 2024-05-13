using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] OrderHistoryPostDto orderHistory)
    {
        int result = await _orderHistoryService.Post(orderHistory);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] OrderHistoryPostDto orderHistory)
    {
        bool result = await _orderHistoryService.Put(orderHistory, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _orderHistoryService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
