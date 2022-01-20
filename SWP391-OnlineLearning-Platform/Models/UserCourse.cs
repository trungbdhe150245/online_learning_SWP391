using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	public class UserCourse
	{
		[Key]
		public int Id { get; set; }
		public DateTime End_Date { get; set; }
		public DateTime Start_Date { get; set; }
		public int Registration_Status { get; set; }
		
	}
}
