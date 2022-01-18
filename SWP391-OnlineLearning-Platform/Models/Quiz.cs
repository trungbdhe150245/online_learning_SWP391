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
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Name { get; set; }
        [Required]
        public int Number_question { get; set; }
        [Required]
        public float Pass_rate { get; set; }
        [DisplayName("Course")]
        public int Course_Id { get; set; }
        [DisplayName("Quiz_Level")]
        public int Quiz_Level_Id { get; set; }
        [DisplayName("Quiz_Type")]
        public int Quiz_Type_Id { get; set; }
        [ForeignKey("Course_Id")]
        public virtual Course Course { get; set; }
        [ForeignKey("Quiz_Level_Id")]
        public virtual Quiz_Level Quiz_Level { get; set; }
        [ForeignKey("Quiz_Type_Id")]
        public virtual Quiz_Type Quiz_Type { get; set; }
    }
}
