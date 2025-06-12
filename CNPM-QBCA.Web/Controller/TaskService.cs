using CNPM_QBCA.Models;

namespace CNPM_QBCA.Services
{
    public class TaskService
    {
        private static List<TaskModel> tasks = new List<TaskModel>
        {
            new TaskModel { Id = 1, Title = "Soát đề HK1", Description = "Kiểm tra nội dung & trùng lặp", AssignedBy = "Head of Dept", AssignedTo = "Lecturer A", Deadline = DateTime.Now.AddDays(3), Status = "Pending" },
            new TaskModel { Id = 2, Title = "Đánh giá đề thi thử", Description = "Phân tích mức độ khó", AssignedBy = "Subject Leader", AssignedTo = "Lecturer A", Deadline = DateTime.Now.AddDays(5), Status = "In Progress" }
        };

        public List<TaskModel> GetTasksForUser(string user)
        {
            return tasks.Where(t => t.AssignedTo == user).ToList();
        }

        public TaskModel GetTaskById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateTaskStatus(int id, string status)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) task.Status = status;
        }
    }
}
