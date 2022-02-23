using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("QuizLevels")]
	public class QuizLevel
	{
		public string QuizLevelId { get; set; }
		public string Name { get; set; }
		public ICollection<QuestionBank> QuestionBanks { get; set; }
		public ICollection<Quiz> Quizzes { get; set; }
	}
}
