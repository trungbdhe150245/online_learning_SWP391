using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Slides")]
    public class Slide
    {
        public int SlideId { get; set; }
        public string SlideValue { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
