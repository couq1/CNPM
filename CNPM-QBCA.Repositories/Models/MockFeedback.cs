using Microsoft.AspNetCore.Mvc;

namespace CNPM_QBCA.Models
{
    public class MockFeedback
    {
        public int Id { get; set; }
        public int MockExamId { get; set; }
        public string LecturerId { get; set; }
        public string Comments { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
