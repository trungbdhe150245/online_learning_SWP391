using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
	[Table("Packages")]
	public class Package
	{
        public string PackageId { get; set; }
        public string PackageName { get; set; }
		public string PackageDescription { get; set; }
		public int PackagePrice { get; set; }
	}
}
