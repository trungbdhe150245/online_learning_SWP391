using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Dimension
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255,ErrorMessage = "Not exceed 255")]
        public string Description { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Name { get; set; }
        [DisplayName("Dimension_Type")]
        public int Type_Id { get; set; }
        [ForeignKey("Type_Id")]
        public virtual Dimension_Type Dimension_Type { get; set; }

        public List<Course_Dimension> Course_Dimensions { get; set; }

        public List<Question_Dimension> Question_Dimensions { get; set; }
    }
}
