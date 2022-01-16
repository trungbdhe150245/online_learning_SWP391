using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string Name { get; set; }
    }
}
