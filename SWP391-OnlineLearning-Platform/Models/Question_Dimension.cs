using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Question_Dimension
    {
        public int Question_Id { get; set; }
        public int Dimension_Id { get; set; }

        public virtual Question_Bank Question_Bank { get; set; }

        public virtual Dimension Dimension { get; set; }
    }
}
