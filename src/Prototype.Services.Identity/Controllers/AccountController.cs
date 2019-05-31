using System.Threading.Tasks;
using Prototype.Common.Commands;
using Prototype.Services.Identity.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Prototype.Services.Identity.Controllers
{
    [Route("")]
    [EnableCors("CorsPolicy")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthenticateUser command)
            => Json(await _userService.LoginAsync(command.Email, command.Password));
    }
}