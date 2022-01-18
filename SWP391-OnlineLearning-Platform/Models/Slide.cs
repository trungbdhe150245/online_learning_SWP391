using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Slide
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255,ErrorMessage = "Not exceed 255")]
        public string Course_link { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Description { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Image_Url { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Title { get; set; }
        [DisplayName("Status")]
        public int Status_Id { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }
    }
}
