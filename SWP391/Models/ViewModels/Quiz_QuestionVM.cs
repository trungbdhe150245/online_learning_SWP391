using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models.ViewModels
{
    public class Quiz_QuestionVM
    {
        public Quiz quiz { get; set; }
        public List<QuestionBank> list_question { get; set; }
    }
}
