using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Topics")]
	public class Topic
	{
		public string TopicId { get; set; }
		public int TopicOrder { get; set; }
		public string TopicName { get; set; }
		public virtual Course Course { get; set; }
		public string CourseId { get; set; }
		public ICollection<Lesson> Lessons { get; set; }
 	}
}
