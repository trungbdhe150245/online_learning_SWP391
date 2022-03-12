using System.Collections.Generic;

namespace SWP391.Models
{
    public class QuizType
    {
        public int QuizTypeId { get; set; }
        public string QuizTypeName { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
    }
}
