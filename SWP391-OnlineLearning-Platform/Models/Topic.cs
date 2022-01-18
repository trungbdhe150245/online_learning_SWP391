using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Topic
    {
        [Key]
        [Required]
        public int Topic_Id { get; set; }
        [Required]
        public int Topic_Order { get; set; }
        [Required]
        [MaxLength(255,ErrorMessage = "Not exceed 255")]
        public string Topic_Name { get; set; }
        [DisplayName("Course")]
        public int Course_Id { get; set; }
        [ForeignKey("Course_Id")]
        public virtual Course Course { get; set; }
    }
}
