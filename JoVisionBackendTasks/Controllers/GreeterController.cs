using Microsoft.AspNetCore.Mvc;

namespace JoVisionBackendTasks.Controllers  
{
    [ApiController]
    [Route("api/[controller]")]       
    public class GreeterController : ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get([FromQuery] string? name)
        {
            string finalName = string.IsNullOrWhiteSpace(name) ? "anonymous" : name;
            return Ok($"Hello {finalName}");
        }
    }
}
