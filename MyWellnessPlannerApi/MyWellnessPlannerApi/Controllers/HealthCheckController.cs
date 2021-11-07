using Microsoft.AspNetCore.Mvc;

namespace MyWellnessPlannerApi.Controllers
{
    [ApiController]
    [Route("/healthcheck")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public IActionResult IsHealthy()
        {
            return Ok();
        }
    }
}
