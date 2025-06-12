using Microsoft.AspNetCore.Mvc;

namespace CNPM_QBCA.Models
{
    public class MockQuestion
    {
        public int Id { get; set; }
        public int MockExamId { get; set; }
        public string Content { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
