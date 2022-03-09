using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("PricePackages")]
    public class PricePackage
    {
        public string PricePackageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
        public int Duration { get; set; }
        public DateTime? StartTime { get; set; }

        public virtual Status Status { get; set; }
        public string StatusId { get; set; }
        public ICollection<CoursePackage> CoursePackages { get; set; }
        public ICollection<UserCourse> UserCourses { get; set; }
    }
}
