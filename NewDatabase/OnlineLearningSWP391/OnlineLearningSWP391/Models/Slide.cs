using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Slide
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Course_link { get; set; }
        public virtual string Description { get; set; }
        public virtual string ImageURL { get; set; }
        public virtual string Title { get; set; }
        public virtual int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
    }
}
