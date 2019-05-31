using System.Threading.Tasks;
using Prototype.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Prototype.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController: Controller
    {
        private readonly IBusClient _busClient;

        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await _busClient.PublishAsync(command);

            return Json("yes");
        }
    }
}