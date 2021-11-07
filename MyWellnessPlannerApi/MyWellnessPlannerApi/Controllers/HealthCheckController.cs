using Microsoft.AspNetCore.Mvc;

namespace MyWellnessPlannerApi.Controllers
{
    [ApiController]
    [Route("")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public IActionResult IsHealthy()
        {
            return Ok();
        }
    }
}
