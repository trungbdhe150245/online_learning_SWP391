using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models.ViewModels
{
    public class Blog_Elements
    {
        public IEnumerable<Category> category { get; set; }
        public int selectedCategoryId { get; set; }
        public IEnumerable<Blog> blogs { get; set; }
        public Blog blog { get; set; }

    }
}
