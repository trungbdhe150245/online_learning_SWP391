using Microsoft.AspNetCore.Identity;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningSWP391.Models
{
	public class AppUser: IdentityUser
	{
		/*
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
		 */
		public virtual string AvatarURL { get; set; }
		public virtual string FullName { get; set; }
		public virtual int Gender { get; set; }
        public virtual int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        public List<Owner> Owners { get; set; }
    }
}
