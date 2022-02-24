using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Attempts")]
	public class Attempt
	{
		public string AttemptId { get; set; }
		public float TotalMark { get; set; }
		public DateTime? StartTime { get; set; }
		public virtual AppUser User { get; set; }
		public string UserId { get; set; }
		public virtual Quiz Quiz { get; set; }
		public string QuizId { get; set; }
		public ICollection<AttemptDetailed> AttemptDetaileds { get; set; }

	}
}
