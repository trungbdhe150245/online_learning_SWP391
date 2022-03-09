using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("Status")]
    public class Status
    {
        public string StatusId { get; set; }
        public string Value { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<PricePackage> PricePackages { get; set; }
        public ICollection<QuestionBank> QuestionBanks { get; set; }

    }
}
