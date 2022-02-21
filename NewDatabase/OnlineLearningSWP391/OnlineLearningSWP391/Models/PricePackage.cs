using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class PricePackage
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual float ListPrice { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        [ForeignKey("StatusId")]
        public virtual int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public virtual List<CoursePackage> CoursePackages { get; set; }
    }
}
