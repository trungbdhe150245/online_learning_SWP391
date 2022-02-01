using Microsoft.AspNetCore.Mvc;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using PagedList.Core;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class PublicFeatureController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public PublicFeatureController(OnlineLearningDbContext db)
        {
            _db = db;
        }

        //PHÂN TRANG
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var IsBlogs = _db.Blogs.OrderByDescending(x => x.Id);
            PagedList<Blog> models = new PagedList<Blog>(IsBlogs, pageNumber, pageSize);
            return View(models);

        }
        public IActionResult BlogList()
        {
            
            return View();
        }

        public IActionResult BlogDetail()
        {
            return View();
        }
    }
}
