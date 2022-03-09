using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("CourseOwners")]
    public class CourseOwner
    {
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public virtual Course Course { get; set; }
        public string CourseId { get; set; }
        public DateTime PurchaseTime { get; set; }
    }
}
