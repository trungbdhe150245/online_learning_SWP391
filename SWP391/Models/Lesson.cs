using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Lessons")]
	public class Lesson
	{
		public string LessonId { get; set; }
		public string LessonName { get; set; }
		public int LessonOrder { get; set; }
		public string HtmlContent { get; set; }
		public string VideoLink { get; set; }
		public virtual Status Status { get; set; }
		public string StatusId { get; set; }
		public virtual Topic Topic { get; set; }
		public string TopicId { get; set; }
	}
}
