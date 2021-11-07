using Microsoft.AspNetCore.Mvc;

namespace MyWellnessPlannerApi.Controllers
{
    [ApiController]
    [Route("/healthcheck")]
    public class HealthCheckController : Controller
    {
        /// <summary>
        /// Used to ensure the health of the application
        /// </summary>
        [HttpGet]
        public IActionResult IsHealthy()
        {
            return Ok();
        }
    }
}
