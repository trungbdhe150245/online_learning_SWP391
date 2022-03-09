using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
    /*
public class IdentityUser
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
}
	 */
    public class AppUser: IdentityUser
    {
        public string FullName { set; get; }
        //      public string Address { set; get; }
        //      [DataType(DataType.Date)]
        //      public DateTime? Birthday { set; get; }
        //public string Sex { get; set; }
        public bool Subcription { get; set; }
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImgFile { get; set; }
        public string ProfilePictureURL { get; set; }
		public ICollection<CourseOwner> CourseOwners { get; set; }
		public ICollection<Attempt> Attempts { get; set; }
		public ICollection<UserCourse> UserCourses { get; set; }
		public ICollection<Blog> Blogs { get; set; }
		public ICollection<Comment> Comments { get; set; }
	}
}
