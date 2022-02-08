using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Course_Dimension
    {
        public int Course_Id { get; set; }
        public int Dimension_Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Dimension Dimension { get; set; }
    }
}
