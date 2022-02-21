using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class CoursePackage
    {
        public virtual int CourseId { get; set; }
        public virtual int PackageId { get; set; }

        public virtual Course Course { get; set; }

        public virtual PricePackage PricePackage { get; set; }
    }
}
