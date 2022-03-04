using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Views.ViewModel
{
    public class NewCourseVM
    {
        public Course Course { get; set; }

        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
