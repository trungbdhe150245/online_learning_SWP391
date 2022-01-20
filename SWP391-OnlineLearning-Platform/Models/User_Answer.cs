using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	public class User_Answer
	{
		/// <summary>
		/// Model for user answer
		/// Update: field name: User_Choice -> Answer
		/// </summary>
		public int Id { get; set; }
		public string Answer { get; set; }
		public int Question_Id { get; set; }
		public int User_Quiz_Id { get; set; }

	}
}
