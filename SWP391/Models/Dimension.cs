using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class Dimension
	{
		public string DimensionId { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }
		public virtual DimensionType DimensionType { get; set; }
		public string DimensionTypeId { get; set; }
		public ICollection<QuestionDimension> QuestionDimensions { get; set; }
		public ICollection<CourseDimension> CourseDimensions { get; set; }
	}
}
