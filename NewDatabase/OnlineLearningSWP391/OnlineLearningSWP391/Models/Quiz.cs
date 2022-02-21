using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Quiz
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual int Duration { get; set; }
        public virtual string Name { get; set; }
        public virtual int Numberquestion { get; set; }
        public virtual float PassRate { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int QuizLevelId { get; set; }
        public virtual int QuizTypeId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("QuizLevelId")]
        public virtual QuizLevel QuizLevel { get; set; }
        [ForeignKey("QuizTypeId")]
        public virtual QuizType QuizType { get; set; }

        public virtual List<QuizQuestion> QuizQuestions { get; set; }
    }
}
