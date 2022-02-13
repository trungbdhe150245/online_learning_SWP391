using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Value { get; set; }

    }
}
