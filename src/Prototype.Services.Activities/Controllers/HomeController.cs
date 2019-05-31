using Microsoft.AspNetCore.Mvc;

namespace Prototype.Services.Activities.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from Prototype.Services.Activites API!");
    }
}