using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models.ViewModels
{
    public class Quiz_QuestionVM
    {
        public Quiz quiz { get; set; }
        public List<Question_Bank> list_question { get; set; }
    }
}
