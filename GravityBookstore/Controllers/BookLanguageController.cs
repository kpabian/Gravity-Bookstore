using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] BookLanguagePostDto bookLanguage)
    {
        int result = await _bookLanguageService.Post(bookLanguage);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] BookLanguagePostDto bookLanguage)
    {
        bool result = await _bookLanguageService.Put(bookLanguage, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _bookLanguageService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
