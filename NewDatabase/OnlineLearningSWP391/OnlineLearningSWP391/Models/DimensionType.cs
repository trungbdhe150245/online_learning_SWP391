using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class DimensionType
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
    }
}
