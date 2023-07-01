using TaskManagement.Models;

namespace TaskManagement.Interfaces
{
    public interface IRepository
    {
        Task<string> CreateUser(UserDTO json);
        Task<string> GetUserTasks(int id);
        Task<string> CreateTask(TaskDTO json);
        Task<string> EditTask(TaskDTO json, int taskId);
        Task<string> DeleteTask(int taskId);
        Task<string> CompleteTask(int taskId);
        Task<string> GetTasks();
        Task<string> GetTask(int id);
        Task<string> CreateComment(CommentDTO json);
        Task<string> GetComments(int id);
    }
}
