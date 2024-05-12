using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShippingMethodController : Controller
{
    private readonly IShippingMethodService _shippingMethodService;

    public ShippingMethodController(IShippingMethodService shippingMethodService)
    {
        _shippingMethodService = shippingMethodService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ShippingMethodDto>>> Get([FromQuery] int id)
    {
        List<ShippingMethodDto> result = await _shippingMethodService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
