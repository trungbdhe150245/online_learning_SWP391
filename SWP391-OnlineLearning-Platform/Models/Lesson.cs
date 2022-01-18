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
        [Required]
        public int Lesson_Id { get; set; }
        [Required]
        public string Html_Content { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Lesson_Name { get; set; }
        [Required]
        public int Lesson_Order { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Video_Link { get; set; }
        [DisplayName("Status")]
        public  int Status_Id { get; set; }
        [DisplayName("Topic")]
        public int Topic_Id { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }
        [ForeignKey("Topic_Id")]
        public virtual Topic Topic { get; set; }
    }
}
