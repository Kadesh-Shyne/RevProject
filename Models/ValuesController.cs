using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReventTechnologyAPI.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevApiController : ControllerBase
    {
        private readonly RevApiController apiController;
        public RevApiController(RevApiController _apiController)
        {
            apiController = _apiController;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Index(string id)
        {

            return await Index(id);
        }

    }
}
