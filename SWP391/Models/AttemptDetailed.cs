using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("AttemptDetaileds")]
    public class AttemptDetailed
    {
        public virtual Attempt Attempt { get; set; }
        public string AttemptId { get; set; }
        public virtual QuestionBank QuestionBank { get; set; }
        public string QuestionBankId { get; set; }
        public string UserAnswer { get; set; }


    }
}
