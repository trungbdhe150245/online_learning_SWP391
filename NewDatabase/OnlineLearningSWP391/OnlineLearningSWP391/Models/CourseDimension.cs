using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class CourseDimension
    {
        public virtual int CourseId { get; set; }
        public virtual int DimensionId { get; set; }

        public virtual Course Course { get; set; }

        public virtual Dimension Dimension { get; set; }
    }
}
