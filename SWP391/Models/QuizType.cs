using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	public class QuizType
	{
		public string QuizTypeId { get; set; }
		public string Name { get; set; }
		public ICollection<Quiz> Quizzes { get; set; }
	}
}
