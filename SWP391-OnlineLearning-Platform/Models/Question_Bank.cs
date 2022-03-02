using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Question_Bank
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Answer { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Content { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Explanation { get; set; }
        [DisplayName("Course")]
        public int Course_Id { get; set; }
        [DisplayName("Quiz_Level")]
        public int Level_Id { get; set; }
        [DisplayName("Status")]
        public int Status_Id { get; set; }
        [ForeignKey("Course_Id")]
        public virtual Course Course { get; set; }
        [ForeignKey("Level_Id")]
        public virtual Quiz_Level Quiz_Level { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }
        [Required]
        public string OptionA { get; set; }
        [Required]
        public string OptionB { get; set; }
        [Required]
        public string OptionC { get; set; }
        [Required]
        public string OptionD { get; set; }

        public List<Quiz_Question> Quiz_Questions { get; set; }

        public List<Question_Dimension> Question_Dimensions { get; set; }
    }
}
