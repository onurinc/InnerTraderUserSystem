using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InnerTraderUserSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet(template:"GetAllUsers")]
        public IActionResult Get()
        {
            return Ok("Test");

        }

    }
}
