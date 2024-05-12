using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : Controller
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CountryDto>>> Get([FromQuery] int id)
    {
        List<CountryDto> result = await _countryService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
