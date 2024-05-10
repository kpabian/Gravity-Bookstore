using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
