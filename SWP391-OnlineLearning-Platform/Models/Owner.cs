using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Owner
    {
        public int User_Id { get; set; }

        public int Course_Id { get; set; }

        public virtual User User { get; set; }

        public virtual Course Course { get; set; }
    }
}
