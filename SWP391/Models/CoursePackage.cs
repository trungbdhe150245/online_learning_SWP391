using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("CoursePackages")]
	public class CoursePackage
	{
		public virtual Course Course { get; set; }
		public string CourseId { get; set; }
		public virtual PricePackage PricePackage { get; set; }
		public string PricePackageId { get; set; }
	}
}
