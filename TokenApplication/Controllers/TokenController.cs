using Microsoft.AspNetCore.Mvc;

namespace TokenApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetToken()
        {
            return Ok("Token is working!");
        }
    }
}
