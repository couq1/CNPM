namespace CNPM_QBCA.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssignedBy { get; set; }
        public string AssignedTo { get; set; } // Email hoặc tên người dùng
        public DateTime Deadline { get; set; }
        public string Status { get; set; } // "Pending", "In Progress", "Completed"
    }
}
