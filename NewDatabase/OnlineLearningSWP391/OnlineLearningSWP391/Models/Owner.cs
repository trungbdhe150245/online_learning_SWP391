using OnlineLearningSWP391.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Owner
    {
        public virtual string UserId { get; set; }

        public virtual int CourseId { get; set; }

        public virtual AppUser User { get; set; }

        public virtual Course Course { get; set; }
    }
}
