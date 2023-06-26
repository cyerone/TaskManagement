using Microsoft.AspNetCore.Mvc;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [ApiController]
    [Route("api")]
    public class TasksController : Controller
    {
        private readonly IRepository _repository;
        public TasksController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("task")]
        public async Task<IActionResult> GetTasks()
        {
            try
            {
                return new OkObjectResult(await _repository.GetTasks());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("task/{id}")]
        public async Task<IActionResult> GetTasks(int id)
        {
            try
            {
                return new OkObjectResult(await _repository.GetTask(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("tasks/{taskId}/comments")]
        public async Task<IActionResult> GetTaskComments(int taskId)
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

        [HttpPost("task")]
        public async Task<IActionResult> CreateTask(TaskDTO task)
        {
            try
            {
                return new OkObjectResult(await _repository.CreateTask(task));
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("task/{id}")]
        public async Task<IActionResult> EditTask(TaskDTO task, int id)
        {
            try
            {
                return new OkObjectResult(await _repository.EditTask(task,id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("task/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                return new OkObjectResult(await _repository.DeleteTask(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut("task/{id}/complete")]
        public async Task<IActionResult> CompleteTask(int id)
        {
            try
            {
                return new OkObjectResult(await _repository.CompleteTask(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}


