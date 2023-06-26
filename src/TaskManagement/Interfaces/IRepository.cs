using TaskManagement.Models;

namespace TaskManagement.Interfaces
{
    public interface IRepository
    {
        public Task<string> CreateUser(UserDTO json);
        public Task<string> GetUserTasks(int id);
        public Task<string> CreateTask(TaskDTO json);
        public Task<string> EditTask(TaskDTO json, int taskId);
        public Task<string> DeleteTask(int taskId);
        public Task<string> CompleteTask(int taskId);
        public Task<string> GetTasks();
        public  Task<string> GetTask(int id);
        public Task<string> CreateComment(CommentDTO json);
        public Task<string> GetComments(int id);
    }
}
