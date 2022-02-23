using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Slides")]
	public class Slide
	{
		public string SlideId { get; set; }
		public string Title { get; set; }
		public string CourseURL { get; set; }
		public string ThumbnailURL { get; set; }
		public string Description { get; set; }
		public virtual Status Status { get; set; }
		public string StatusId { get; set; }

	}
}
