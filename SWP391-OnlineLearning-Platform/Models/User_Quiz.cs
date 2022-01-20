using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	/// <summary>
	/// Model for taken quizzes
	/// </summary>
	public class User_Quiz
	{
		public int Id { get; set; }
		public float Mark { get; set; }
		public float Start_Time { get; set; } //last_attempt
		public int Quiz_Id { get; set; }
		public int User_Id { get; set; }

	}
}
