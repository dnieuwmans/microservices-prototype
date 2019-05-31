using Microsoft.AspNetCore.Mvc;

namespace Prototype.Services.Identity.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from Prototype.Services.Identity API!");
    }
}