using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Course_Package
    {
        public int Course_Id { get; set; }
        public int Package_Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Price_Package Price_Package { get; set; }
    }
}
