using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class QuestionDimension
    {
        public int QuestionId { get; set; }
        public int DimensionId { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }

        public virtual Dimension Dimension { get; set; }
    }
}
