using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class Dimension
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Name { get; set; }
        public virtual int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual DimensionType DimensionType { get; set; }

        public virtual List<CourseDimension> CourseDimensions { get; set; }

        public virtual List<QuestionDimension> QuestionDimensions { get; set; }
    }
}
