using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Comment
    {
        [Key]
        public int Comment_Id { get; set; }
        [DisplayName("User")]
        public int User_Id { get; set; }
        [DisplayName("Blog")]
        public int Blog_Id { get; set; }
        public string Content { get; set; }
        public DateTime Date_Created { get; set; }

        [ForeignKey("User_Id")]
        public virtual User User { get; set; }

        [ForeignKey("Blog_Id")]
        public virtual Blog Blog { get; set; }
    }
}
