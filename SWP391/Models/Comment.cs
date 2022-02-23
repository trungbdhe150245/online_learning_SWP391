using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Comments")]
	public class Comment
	{
		public string CommentId { get; set; }
		public string CommentBody { get; set; }
		public virtual Blog Blog { get; set; }
		public string BlogId { get; set; }
		public virtual AppUser User { get; set; }
		public string UserId { get; set; }
	}
}
