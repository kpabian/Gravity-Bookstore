using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
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
}
