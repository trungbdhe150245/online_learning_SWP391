using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class DimensionType
	{
		public string DimensionTypeId { get; set; }
		public string Name { get; set; }
		public ICollection<Dimension> Dimensions { get; set; }
	}
}
