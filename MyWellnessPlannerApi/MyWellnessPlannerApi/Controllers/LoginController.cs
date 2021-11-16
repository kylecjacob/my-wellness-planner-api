using Microsoft.AspNetCore.Mvc;
using MyWellnessPlannerApi.Models;
using MyWellnessPlannerApi.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace MyWellnessPlannerApi.Controllers
{
    [ApiController]
    [Route("/api/login")]
    public class LoginController : Controller
    {
        private readonly ITokenService _tokenService;
        public LoginController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        /// <summary>
        /// Is called on logging in to application, checks if valid credentials are sent
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public IActionResult Login(LoginRequest request)
        {
            // TODO: Check if user exists in DB
            try
            {
                var response = new LoginResponse
                {
                    Token = _tokenService.GenerateToken(request?.Email)
                };
                return Ok(response);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
