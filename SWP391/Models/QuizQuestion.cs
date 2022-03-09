namespace SWP391.Models
{
    public class QuizQuestion
    {
        public virtual Quiz Quiz { get; set; }
        public string QuizId { get; set; }
        public virtual QuestionBank QuestionBank { get; set; }
        public string QuestionId { get; set; }
    }
}
