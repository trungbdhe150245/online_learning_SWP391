using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models 
{ 
    [Table("UserPricePackages")]
    public class UserPricePackage
    {
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public virtual PricePackage PricePackage{ get; set; }
        public int PricePackageId { get; set; }
        public int RemainingDay { get; set; }
        public DateTime SubcribeDate { get; set; }
    }
}
