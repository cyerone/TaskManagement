namespace TaskManagement.Models
{
    public class TaskDTO
    {
        public int userId { get; set; }
        public DateTime dueDate { get; set; }
        public int priority { get; set; }
        public string description { get; set; }
        public bool isComplete { get; set; }
    }
}
