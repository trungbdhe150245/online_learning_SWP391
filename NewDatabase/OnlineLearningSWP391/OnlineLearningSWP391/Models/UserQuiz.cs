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
    public class UserQuiz
    {
        [Key]
        public int Id { get; set; }
        public float Mark { get; set; }
        public DateTime StartTime { get; set; }
        public int QuizId { get; set; }
        public virtual string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        [ForeignKey("QuizId")]
        public virtual Quiz Quiz { get; set; }
    }
}
