using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class QuizQuestion
    {
        public virtual int QuizId { get; set; }
        public virtual int QuestionId { get; set; }

        public virtual Quiz Quiz { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }

    }
}
