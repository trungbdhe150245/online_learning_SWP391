using OnlineLearningSWP391.Models;
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
        public virtual int CommentId { get; set; }
        public virtual string UserId { get; set; }
        public virtual int BlogId { get; set; }
        public virtual string Content { get; set; }
		public virtual DateTime DateCreated { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}
