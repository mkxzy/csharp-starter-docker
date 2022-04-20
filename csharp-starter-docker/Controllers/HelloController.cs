using Microsoft.AspNetCore.Mvc;

namespace csharp_starter_docker.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        [Route("/")]
        [HttpGet]
        public string Hello()
        {
            return "Hello, World!";
        }
    }
}
