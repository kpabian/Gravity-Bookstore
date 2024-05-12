using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerAddressController : Controller
{
    private readonly ICustomerAddressService _customerAddressService;

    public CustomerAddressController(ICustomerAddressService customerAddressService)
    {
        _customerAddressService = customerAddressService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CustomerAddressDto>>> Get([FromQuery] int id)
    {
        List<CustomerAddressDto> result = await _customerAddressService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
