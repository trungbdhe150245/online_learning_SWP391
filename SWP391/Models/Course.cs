﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Courses")]
	public class Course
	{
		public string CourseId { get; set; }
		public string Name { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string Description { get; set; }
		public int Featured { get; set; }
		public string ShortDescription { get; set; }
		public string ThumbnailURL { get; set; }
		public string Title { get; set; }
		public virtual Category Category { get; set; }
		public string CategoryId { get; set; }
		public ICollection<Owner> Owners { get; set; }
		public ICollection<Topic> Topics { get; set; }
		public ICollection<QuestionBank> QuestionBanks { get; set; }
		public ICollection<Quiz> Quizzes { get; set; }
		public virtual Status Status { get; set; }
		public string StatusId { get; set; }
		public ICollection<CoursePackage> CoursePackages { get; set; }
		public ICollection<UserCourse> UserCourses { get; set; }
		public ICollection<CourseDimension> CourseDimensions { get; set; }	
	}
}
