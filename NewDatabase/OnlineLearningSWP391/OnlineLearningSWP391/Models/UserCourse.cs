using OnlineLearningSWP391.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models
{
    public class UserCourse
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual int RegistrationStatus { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int CourseId { get; set; }
        public virtual int PricePackageId { get; set; }
        public virtual string UserId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        [ForeignKey("PricePackageId")]
        public virtual PricePackage PricePackage { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }



    }
}
