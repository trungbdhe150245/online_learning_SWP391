using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Quizzes")]
    public class Quiz
    {
        public string QuizId { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public int QuestionNum { get; set; }
        public virtual Topic Topic { get; set; }
        public int TopicId { get; set; }
        public ICollection<Attempt> Attempts { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual QuizType QuizType { get; set; }
        public int QuizTypeId { get; set; }
        public virtual QuizLevel QuizLevel { get; set; }
        public int QuizLevelId { get; set; }

    }
}
