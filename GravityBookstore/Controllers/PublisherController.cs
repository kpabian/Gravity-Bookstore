using GravityBookstore.IServices;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublisherController : Controller
{
    private readonly IPublisherService _publisherService;

    public PublisherController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PublisherDto>>> Get([FromQuery] int id)
    {
        List<PublisherDto> result = await _publisherService.Get(id);
        if (result.Count <= 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
