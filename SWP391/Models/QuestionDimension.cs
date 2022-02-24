using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class QuestionDimension
	{
		public virtual QuestionBank QuestionBank { get; set; }
		public string QuestionId { get; set; }
		public virtual Dimension Dimension { get; set; }
		public string DimensionId { get; set; }

	}
}
