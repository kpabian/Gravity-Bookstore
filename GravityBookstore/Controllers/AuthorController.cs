using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : Controller
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<AuthorDto>>> Get([FromQuery] int id)
    {
        List<AuthorDto> result = await _authorService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
