using Avalon.Api.Services;
using Avalon.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Avalon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var token = _service.Login(request.UserName, request.Password);
            if (token == null) return Unauthorized();
            return Ok(new { token });
        }
    }
}
