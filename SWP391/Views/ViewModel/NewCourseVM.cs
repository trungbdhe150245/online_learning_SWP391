using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Models;
using System.Collections.Generic;

namespace SWP391.Views.ViewModel
{
    public class NewCourseVM
    {

        public Course Course { get; set; }

        public Topic Topic { get; set; }

        public Lesson Lesson { get; set; }

        public List<Topic> Topics { get; set; }

        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
