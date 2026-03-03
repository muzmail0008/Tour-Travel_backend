using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApplication.Models;

namespace backend_tour_website.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AdminController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User model)
        {
            if (model.Email == "muzamil113@gmail.com" &&
                model.Password == "25112004")
            {
                return Ok(new { message = "Login Successful" });
            }

            return Unauthorized(new { message = "Invalid credentials" });
        }
    }
}