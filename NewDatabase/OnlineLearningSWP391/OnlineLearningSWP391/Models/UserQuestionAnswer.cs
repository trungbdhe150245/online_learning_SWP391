using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class UserQuestionAnswer
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string UserChoice { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual int UserQuizId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual QuestionBank QuestionBank { get; set; }
        [ForeignKey("UserQuizId")]
        public virtual UserQuiz UserQuiz { get; set; }

    }
}
