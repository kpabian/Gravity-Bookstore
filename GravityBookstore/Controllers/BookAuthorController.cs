using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookAuthorController : Controller
{
    private readonly IBookAuthorService _bookAuthorService;

    public BookAuthorController(IBookAuthorService bookAuthorService)
    {
        _bookAuthorService = bookAuthorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<BookAuthorDto>>> Get([FromQuery] int AuthorId, int BookId)
    {
        List<BookAuthorDto> result = await _bookAuthorService.Get(AuthorId, BookId);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
