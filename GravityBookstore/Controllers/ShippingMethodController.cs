using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] ShippingMethodPostDto shippingMethod)
    {
        int result = await _shippingMethodService.Post(shippingMethod);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] ShippingMethodPostDto shippingMethod)
    {
        bool result = await _shippingMethodService.Put(shippingMethod, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _shippingMethodService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
