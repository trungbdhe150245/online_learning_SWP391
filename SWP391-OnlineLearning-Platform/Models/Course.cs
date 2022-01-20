using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	public class Course
	{
		[Key]
		public int Id { get; set; }
		public DateTime Created_Date { get; set; }
		public string Description { get; set; }
		public string Featured { get; set; }
		public string Short_Description { get; set; }
		public string Thumbnail_Url { get; set; }
		public string Title { get; set; }
		public int Category_Id { get; set; }
		public int Status { get; set; }


	}
}
