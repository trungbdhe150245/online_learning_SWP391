using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class Featured
	{
		public int FeaturedId { get; set; }
		public string Value { get; set; }
		public ICollection<Course> Courses { get; set; }
		public ICollection<Blog> Blogs { get; set; }
	}
}
