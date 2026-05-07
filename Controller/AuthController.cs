using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Entities;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> login(UserDto request) { 
            var result = await authService.LoginAsync(request);
            if (result is null)
                return BadRequest("Invalid username or password");

            return Ok(result);

        }
        [HttpPost("register")]
        public async Task<ActionResult<User>> register(UserDto request) {
            var user = await authService.RegisterAsync(request);
            if (user is null) {
                return BadRequest("User already exist!");
            }
            return Ok(user);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AuthenticatedOnlyEndpoint() {
            return Ok("Hello you are authenticated!");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin-only")]
        public IActionResult AdminOnlyEndpoint() {
            return Ok("Hello you are admin!");
        }
    }
}
