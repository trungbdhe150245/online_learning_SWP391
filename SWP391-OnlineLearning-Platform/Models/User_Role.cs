using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class User_Role
    {
        public int User_Id { get; set; }

        public int Role_Id { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
