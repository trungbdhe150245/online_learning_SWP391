using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("QuestionBanks")]
    public class QuestionBank
    {
        public string QuestionId { get; set; }
        public string Answer { get; set; }
        public string Content { get; set; }
        public string Explanation { get; set; }
        public float Weight { get; set; }
        public virtual QuizLevel QuizLevel { get; set; }
        public string QuizLevelId { get; set; }
        public virtual Course Course { get; set; }
        public string CourseId { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public ICollection<AttemptDetailed> AttemptDetaileds { get; set; }
        public virtual Status Status { get; set; }
        public string StatusId { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
