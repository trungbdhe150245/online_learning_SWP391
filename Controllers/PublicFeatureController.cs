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
using PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class PublicFeatureController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public PublicFeatureController(OnlineLearningDbContext db)
        {
            _db = db;
        }

        public IActionResult BlogList(int? page)
        {
            var blogs = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date);
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 2;
            PagedList<Blog> models = new PagedList<Blog>(blogs, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "Id", "Value");
            ViewData["category"] = _db.Categories.ToList();
            ViewData["recentBlogs"] = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date).ToList();
            return View(models);
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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> BlogList(string? searchString)
        //{
        //    var blogs = from m in _db.Blogs
        //                select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        blogs = blogs.Where(s => s.Title!.Contains(searchString));
        //    }
        //    var category = _db.Categories;
        //    Blog_Elements be = new Blog_Elements();
        //    be.category = category;
        //    be.blogs = blogs;
        //    return View(blogs);
        //}

    }
}
