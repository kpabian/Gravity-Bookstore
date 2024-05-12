using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookLanguageController : Controller
{
    private readonly IBookLanguageService _bookLanguageService;

    public BookLanguageController(IBookLanguageService bookLanguageService)
    {
        _bookLanguageService = bookLanguageService;
    }

    [HttpGet]
    public async Task<ActionResult<List<BookLanguageDto>>> Get([FromQuery] int id)
    {
        List<BookLanguageDto> result = await _bookLanguageService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
