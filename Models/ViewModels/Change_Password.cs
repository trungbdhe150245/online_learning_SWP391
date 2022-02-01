using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models.ViewModels
{
    public class Change_Password
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Old password")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="New Password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm New Password")]
        [Compare("NewPassword",ErrorMessage = "The password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        public string Avatar_Url { get; set; }
        public string Full_Name { get; set; }
        public int Id { get; set; }
    }
}
