using Microsoft.AspNetCore.Mvc;
using UserWebApi.Models;
using UserWebApi.Service;

namespace UserWebApi.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        private readonly AuthService _authService;

        public LoginController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login(LoginDTO request)
        {
            string token = _authService.Authenticate(request.Email, request.Password, request.role);

            if (token != null)
            {
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
