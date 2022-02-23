using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class CourseDimension
	{
		public virtual Course Course { get; set; }
		public string CouresId { get; set; }
		public virtual Dimension Dimension { get; set; }
		public string DimensionId { get; set; }
	}
}
