using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Price_Package
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255,ErrorMessage = "Not exceed 255")]
        public string Discount { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public float List_price { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Name { get; set; }
        [Required]
        public float Sale_Price { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Text { get; set; }
        [DisplayName("Status")]
        public int Status_Id { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }

        public List<Course_Package> Course_Packages { get; set; }
    }
}
