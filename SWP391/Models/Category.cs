using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Categories")]
    public class Category
    {
        public string CategoryId { get; set; }
        public string Value { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
