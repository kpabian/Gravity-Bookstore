using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
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

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] AuthorPostDto author)
    {
        int result = await _authorService.Post(author);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] AuthorPostDto author)
    {
        bool result = await _authorService.Put(author, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _authorService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
