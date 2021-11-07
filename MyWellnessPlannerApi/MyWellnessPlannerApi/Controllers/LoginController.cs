using Microsoft.AspNetCore.Mvc;
using MyWellnessPlannerApi.Models;

namespace MyWellnessPlannerApi.Controllers
{
    [ApiController]
    [Route("/api/login")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Login(LoginRequest request)
        {
            return Ok();
        }
    }
}
