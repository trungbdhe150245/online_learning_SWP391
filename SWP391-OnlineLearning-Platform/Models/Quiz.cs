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
		[Required]
		public string Description { get; set; }
		[Required]
		public float Duration { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int Question_Number { get; set; }
		[Required]
		public string Pass_Rate { get; set; }
		[Required]
		public string Course_Id { get; set; }
		[Required]
		public int Level_Id { get; set; }
		[Required]
		public int Quiz_Type_ID { get; set; }


	}
}
