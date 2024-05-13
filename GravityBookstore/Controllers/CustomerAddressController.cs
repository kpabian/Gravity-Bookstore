using GravityBookstore.IServices;
using GravityBookstore.Models;
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
    public async Task<ActionResult<List<CustomerAddressDto>>> Get([FromQuery] int CustId, int AddressId)
    {
        List<CustomerAddressDto> result = await _customerAddressService.Get(CustId, AddressId);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<(int, int)>> Post([FromBody] CustomerAddressPostDto customerAddress)
    {
        var result = await _customerAddressService.Post(customerAddress);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] CustomerAddressPostDto customerAddress)
    {
        bool result = await _customerAddressService.Put(customerAddress, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _customerAddressService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
