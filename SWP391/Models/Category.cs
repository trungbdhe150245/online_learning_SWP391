using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Categories")]
	public class Category
	{
		public string CategoryId { get; set; }
		public string Value { get; set; }
		public ICollection<Blog> Blogs { get; set; }
		public ICollection<Course> Courses { get; set; }

	}
}
