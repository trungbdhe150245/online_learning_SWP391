using Microsoft.AspNetCore.Mvc;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using SWP391_OnlineLearning_Platform.Models.ViewModels;
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
            var blogs = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date);
            var category = _db.Categories;
            Blog_Elements be = new Blog_Elements();
            be.category = category;
            be.blogs = blogs;
            return View(be);
        }

        public IActionResult BlogDetail(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var blogs = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date);
            var blog = _db.Blogs.Where(s => s.Id == id).Include(a => a.Category).Include(b => b.User).Include(c => c.Status).FirstOrDefault();
            var category = _db.Categories;
            Blog_Elements be = new Blog_Elements();
            be.category = category;
            be.blogs = blogs;
            be.blog = blog;
            if (blog == null)
            {
                return NotFound();
            }
            return View(be);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BlogList(string searchString)
        {
            var blogs = from m in _db.Blogs
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                blogs = blogs.Where(s => s.Title!.Contains(searchString));
            }
            var category = _db.Categories;
            Blog_Elements be = new Blog_Elements();
            be.category = category;
            be.blogs = blogs;
            return View(be);
        }
    }
}
