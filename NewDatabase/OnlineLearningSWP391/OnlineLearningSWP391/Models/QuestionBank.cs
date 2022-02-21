using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class QuestionBank
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Answer { get; set; }
        public virtual string Content { get; set; }
        public virtual string Explanation { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int LevelId { get; set; }
        public virtual int StatusId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("LevelId")]
        public virtual QuizLevel Quiz_Level { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

        public virtual List<QuizQuestion> QuizQuestions { get; set; }

        public virtual List<QuestionDimension> QuestionDimensions { get; set; }
    }
}
