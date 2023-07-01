using Microsoft.AspNetCore.Mvc;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : Controller
    {
        private readonly IRepository _userRepository;
        public UserController(IRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("user")]
        public async Task<IActionResult> CreateUser(UserDTO user)
        {
            try
            {
                return new OkObjectResult(await _userRepository.CreateUser(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("user/{userId}/tasks")]
        public async Task<IActionResult> GetUserTasks(int userId)
        {
            try
            {
                return new OkObjectResult(await _userRepository.GetUserTasks(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
