using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



/*public class IdentityUser
{
    public IdentityUser(string userName);
    public virtual bool TwoFactorEnabled { get; set; }
    public virtual bool PhoneNumberConfirmed { get; set; }
    public virtual string PhoneNumber { get; set; }
    public virtual string SecurityStamp { get; set; }
    public virtual bool EmailConfirmed { get; set; }
    public virtual string Email { get; set; }
    public virtual string UserName { get; set; }
    public virtual string Id { get; set; }
    public virtual bool LockoutEnabled { get; set; }
    public virtual int AccessFailedCount { get; set; }
}*/
namespace SWP391_OnlineLearning_Platform.Models
{
    
    public class User/*: IdentityUser*/
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Auth_Provider { get; set; }
        public string Avatar_Url { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Date Of Birth")]
        public DateTime Dob { get; set; }

        public string Full_Name { get; set; }
        [Range(0,2)]
        public int Gender { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string Phone { get; set; }
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Reset_password_token { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Username { get; set; }
        [MaxLength(255, ErrorMessage = "Not exceed 255")]
        public string Verification_code { get; set; }
        [DisplayName("Status")]
        [Required]
        public int Status_Id { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }

        //public List<User_Role> User_Roles { get; set; }

        public List<Owner> Owners { get; set; }

    }
}
