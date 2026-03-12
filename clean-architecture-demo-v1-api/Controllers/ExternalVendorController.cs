using clean_architecture_demo_v1.App.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clean_architecture_demo_v1_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController(ISender sender) : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetCoindeskData()
        {
            var result = await sender.Send(new GetCoinkdeskDataQuery());
            return Ok(result);
        }

        [HttpGet("joke")]
        public async Task<IActionResult> GetJoke()
        {
            var result = await sender.Send(new GetJokeQuery());
            return Ok(result);
        }
    }
}
