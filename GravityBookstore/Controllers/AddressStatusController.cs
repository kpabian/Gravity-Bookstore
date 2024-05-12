using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
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
}
