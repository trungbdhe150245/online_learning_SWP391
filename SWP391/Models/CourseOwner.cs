using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Owners")]
	public class CourseOwner
	{
		public virtual AppUser User { get; set; }
		public string UserId { get; set; }
		public virtual Course Course { get; set; }
		public string CourseId { get; set; }
        public DateTime PurchaseTime { get; set; }
    }
}
