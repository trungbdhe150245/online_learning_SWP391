using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("UserCourses")]
    public class UserCourse
    {
        public string UserCourseId { get; set; }
        //public virtual Status Status { get; set; }
        //public string StatusId { get; set; }
        public virtual Course Course { get; set; }
        public string CourseId { get; set; }
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public virtual PricePackage PricePackage { get; set; }
        public string PricePackageId { get; set; }
    }
}
