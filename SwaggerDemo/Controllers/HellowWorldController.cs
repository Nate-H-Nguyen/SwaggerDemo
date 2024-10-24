using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class HellowWorldController : ControllerBase
    {
        [HttpGet]
        [Route("GetHelloWorld")]
        public IActionResult Get()
        {
            return Ok("Hello World!!!");
        }
    }
}
