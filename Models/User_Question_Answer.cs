using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class User_Question_Answer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string User_Choice { get; set; }
        [DisplayName("Question_Bank")]
        public int Question_Id { get; set; }
        [DisplayName("User_Quiz")]
        public int User_Quiz_Id { get; set; }
        [ForeignKey("Question_Id")]
        public virtual Question_Bank Question_Bank { get; set; }
        [ForeignKey("User_Quiz_Id")]
        public virtual User_Quiz User_Quiz { get; set; }

    }
}
