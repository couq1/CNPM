using Microsoft.AspNetCore.Mvc;

namespace CNPM_QBCA.Models
{
    public class MockExam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; } // Pending, In Progress, Submitted, Feedback Given
        public ICollection<MockQuestion> Questions { get; set; }
    }

}
