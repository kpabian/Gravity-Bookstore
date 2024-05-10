using Microsoft.AspNetCore.Mvc;

namespace GravityBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookLanguageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
