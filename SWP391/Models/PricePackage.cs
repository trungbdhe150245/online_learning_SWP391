using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Models
{
    [Table("PricePackages")]
    public class PricePackage
    {
        public int PricePackageId { get; set; }
        public string PricePackageName { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
        //public int Duration { get; set; }
        //public DateTime? StartTime { get; set; }

        public ICollection<UserPricePackage> UserPricePackages { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
    }
}
