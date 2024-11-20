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
        public async Task<IActionResult> RegisterUser([FromBody] UserB user)
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



    /// <summary>
    /// Handles user registration requests.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="model">The user registration model.</param>
        /// <returns>A 201 Created response if the user is registered successfully, otherwise a 400 Bad Request response.</returns>
        [HttpPost]
        public IActionResult RegisterUser([FromBody] UserRegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Register the user here (e.g., save to database)

            return CreatedAtAction(nameof(RegisterUser), model);
        }
    }
}
