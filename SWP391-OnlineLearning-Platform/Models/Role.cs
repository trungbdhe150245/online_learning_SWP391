using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int Role_Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Role_Name { get; set; }

        public List<User_Role> User_Roles { get; set; }
    }
}
