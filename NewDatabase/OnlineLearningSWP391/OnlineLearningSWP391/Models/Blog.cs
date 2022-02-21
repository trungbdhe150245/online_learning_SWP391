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
    public class Blog
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual  string Brief { get; set; }
        public virtual string Content { get; set; }
        public virtual string Featured { get; set; }
        public virtual string Thumbnail { get; set; }
        public virtual string Title { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int StatusId { get; set; }
        public virtual string UserId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
         
        
        public virtual DateTime DateCreate { get; set; }


    }
}
