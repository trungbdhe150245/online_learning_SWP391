using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Courses")]
    public class Course
    {
        public string CourseId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ThumbnailURL { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int SlideId { get; set; }
        public virtual Slide Slide { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImgFile { get; set; }
        public ICollection<CourseOwner> CourseOwners { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<QuestionBank> QuestionBanks { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
    }
}
