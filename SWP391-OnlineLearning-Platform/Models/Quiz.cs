using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	/// <summary>
	/// Model for quizzes
	/// </summary>
	public class Quiz
	{
		[Key]
		public int Id { get; set; }
		public string Description { get; set; }
		public float Duration { get; set; }
		public string Name { get; set; }
		public int Question_Number { get; set; }
		public string Pass_Rate { get; set; }
		public string Course_Id { get; set; }
		public int Level_Id { get; set; }
		public int Quiz_Type_ID { get; set; }


	}
}
