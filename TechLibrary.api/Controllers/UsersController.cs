using Microsoft.AspNetCore.Mvc;

namespace TechLibrary.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Create();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Create();
        }
    }
}
