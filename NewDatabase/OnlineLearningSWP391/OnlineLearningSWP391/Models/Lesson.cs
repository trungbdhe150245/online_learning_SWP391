using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Lesson
    {
        [Key]
        public virtual int LessonId { get; set; }
        public virtual string HtmlContent { get; set; }
        public virtual string LessonName { get; set; }
        public virtual int LessonOrder { get; set; }
        public virtual string VideoLink { get; set; }
        public virtual int StatusId { get; set; }
        public virtual int TopicId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
    }
}
