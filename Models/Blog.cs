using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Blog
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Brief { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Featured { get; set; }
        [Required]
        [MaxLength(255,ErrorMessage = "Not exceed 255")]
        public string Thumbnail { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Title { get; set; }
        [DisplayName("Category")]
        public int Category_Id { get; set; }
        [DisplayName("Status")]
        public int Status_Id { get; set; }
        [DisplayName("User")]
        public int User_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Category { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }

        public DateTime Date { get; set; }


    }
}
