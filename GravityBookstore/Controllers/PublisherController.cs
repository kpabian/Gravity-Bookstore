using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublisherController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
