using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Quiz_Question
    {
        public int Quiz_Id { get; set; }
        public int Question_Id { get; set; }

        public virtual Quiz Quiz { get; set; }

        public virtual Question_Bank Question_Bank { get; set; }

    }
}
