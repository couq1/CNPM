using System;
using System.Collections.Generic;

namespace CNPM_QBCA.Models
{
    public class MockExamViewModel
    {
        public int ExamId { get; set; } // Cho @Model.ExamId
        public string Title { get; set; }
        public string Instructions { get; set; } // Cho @Model.Instructions
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public string AssignedBy { get; set; }

        public List<MockQuestion> Questions { get; set; }
        public List<string> Answers { get; set; } = new(); // hoặc Dictionary<int, string>
    }
}