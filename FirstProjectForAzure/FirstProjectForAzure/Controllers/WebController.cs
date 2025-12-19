using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProjectForAzure.Controllers
{
    [Route("api/web/")]
    [ApiController]
    public class WebController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }
        [HttpGet("time")]
        public IActionResult Time()
        {
            return Ok(DateTime.Now.ToString());
        }
        [HttpPost("sum")]
        public IActionResult Sum(int a, int b)
        {
            return Ok(a + b);
        }
    }
}
