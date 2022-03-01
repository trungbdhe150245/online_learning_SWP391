using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models.ViewModels
{
    public class NewCourseVM
    {
        public Course Course { get; set; }

        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
