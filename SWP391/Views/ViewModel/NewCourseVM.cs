using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Models;
using System.Collections.Generic;

namespace SWP391.Views.ViewModel
{
    public class NewCourseVM
    {
        public Course Course { get; set; }

        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
