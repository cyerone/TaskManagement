using Microsoft.AspNetCore.Mvc;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("api")]
    public class CommentController : Controller
    {
        private readonly IRepository _repository;
        public CommentController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("comment")]
        public async Task<IActionResult> CreateComment(CommentDTO comment)
        {
            try
            {
                return new OkObjectResult(await _repository.CreateComment(comment));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("comments/{taskId}")]
        public async Task<IActionResult> GetComments(int taskId)
        {
            try
            {
                return new OkObjectResult(await _repository.GetComments(taskId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
