using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressStatusController : Controller
{
    private readonly IAddressStatusService _addressStatusService;

    public AddressStatusController(IAddressStatusService addressStatusService)
    {
        _addressStatusService = addressStatusService;
    }

    [HttpGet]
    public async Task<ActionResult<List<AddressStatusDto>>> Get([FromQuery] int id)
    {
        List<AddressStatusDto> result = await _addressStatusService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] AddressStatusPostDto addressStatus)
    {
        int result = await _addressStatusService.Post(addressStatus);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] AddressStatusPostDto addressStatus)
    {
        bool result = await _addressStatusService.Put(addressStatus, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _addressStatusService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
