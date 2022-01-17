using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SWP391_OnlineLearning_Platform.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UserLogin class
    public class UserLogin : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FullName { get; set; }
        [PersonalData]
        [Column(TypeName = "bit")]
        public bool Gender { get; set; }
        [PersonalData]
        [Column(TypeName = "datetime")]
        public DateTime DOB { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Phone { get; set; }
    }
}
