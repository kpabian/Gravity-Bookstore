using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustOrderController : Controller
{
    private readonly ICustOrderService _custOrderService;

    public CustOrderController(ICustOrderService custOrderService)
    {
        _custOrderService = custOrderService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CustOrderDto>>> Get([FromQuery] int id)
    {
        List<CustOrderDto> result = await _custOrderService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] CustOrderPostDto custOrder)
    {
        int result = await _custOrderService.Post(custOrder);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] CustOrderPostDto custOrder)
    {
        bool result = await _custOrderService.Put(custOrder, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _custOrderService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
