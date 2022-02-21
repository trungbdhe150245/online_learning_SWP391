using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public enum SortOrder { Asc=0,Desc=1 }
    public class Course
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string Description { get; set; }
        public virtual int Featured { get; set; }
        
        public virtual string ShortDescription { get; set; }
        public virtual string ThumbnailURL { get; set; }
        public virtual string Title { get; set; }
        public virtual int CategoryId { get; set; }
        [ForeignKey("StatusId")]
        public virtual int StatusId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual Status Status { get; set; }

        public virtual List<Owner> Owners { get; set; }

        public virtual List<CoursePackage> CoursePackages { get; set; }

        public virtual List<CourseDimension> CourseDimensions { get; set; }
    }
}
