using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
	/// <summary>
	/// Model for questions
	/// Update: remove option 1->4 (for adding essay questions)
	/// Update: field name changed: Answer -> Solution
	/// </summary>
	public class Question
	{
		[Key]
		public int Id { get; set; }
		public string Solution { get; set; } 
		public string Content { get; set; }
		public string Explanation { get; set; }
		public int CourseId { get; set; }
		public int LevelId { get; set; }
		public int StatusId { get; set; }
	}
}
