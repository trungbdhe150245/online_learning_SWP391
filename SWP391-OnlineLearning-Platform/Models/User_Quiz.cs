using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class User_Quiz
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public float Mark { get; set; }
        [Required]
        public DateTime Start_Time { get; set; }
        [DisplayName("Quiz")]
        public int Quiz_Id { get; set; }
        [DisplayName("User")]
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
        [ForeignKey("Quiz_Id")]
        public virtual Quiz Quiz { get; set; }
    }
}
