using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class User_Course
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public DateTime End_Date { get; set; }
        public int Registration_Status { get; set; }
        public DateTime Start_Date { get; set; }
        [DisplayName("Course")]
        public int Course_Id { get; set; }
        [DisplayName("Price_Package")]
        public int Price_Package_Id { get; set; }
        [DisplayName("User")]
        public int User_Id { get; set; }
        
        [ForeignKey("Course_Id")]
        public virtual Course Course { get; set; }
        [ForeignKey("Price_Package_Id")]
        public virtual Price_Package Price_Package { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User { get; set; }



    }
}
