using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Controllers
{
    /// <summary>
    /// Handles user registration operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Updated UserController.cs
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TO DO: Implement user registration logic here
            // For demonstration purposes, just return a 201 Created response
            return CreatedAtAction(nameof(RegisterUser), new { id = user.Email }, user);
        }
    }
}
