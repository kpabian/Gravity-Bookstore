using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<ActionResult<List<BookDto>>> Get([FromQuery] int id)
    {
        List<BookDto> result = await _bookService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpGet("publisher")]
    public async Task<ActionResult<List<BookPublisherDto>>> GetByPublisherName([FromQuery] string name)
    {
        List<BookPublisherDto> result = await _bookService.GetByPublisherName(name);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post([FromBody] BookPostDto book)
    {
        int result = await _bookService.Post(book);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> Put(int id, [FromBody] BookPostDto book)
    {
        bool result = await _bookService.Put(book, id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        bool result = await _bookService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
