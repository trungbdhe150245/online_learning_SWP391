using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Persistent_Login
    {
        [Key]
        [Required]
        [MaxLength(50,ErrorMessage = "Not exceed 50")]
        public string Series { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Not exceed 50")]
        public string Username { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Not exceed 50")]
        public string Token { get; set; }
        [Required]
        public DateTime Last_Used { get; set; }

    }
}
