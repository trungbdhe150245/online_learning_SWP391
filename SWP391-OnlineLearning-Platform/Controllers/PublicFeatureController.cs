using Microsoft.AspNetCore.Mvc;
//using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
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

        public IActionResult Filter(int CatID = 0)
        {
            var url = $"/publicfeature/blogList?catID={CatID}";
            if (CatID == 0)
            {
                url = $"/publicfeature/blogList";
            }
            return Json(new { status = "success", redirectUrl = url });
        }

        public IActionResult BlogList(string keyWord, int CatID = 0, int page = 1)
        {
            //PHÂN TRANG
            var pageNumber = page;
            var pageSize = 2;
            ViewBag.CurrentPage = pageNumber;

            //LỌC BLOG THEO CATEGORY
            List<Blog> blogs = new List<Blog>();
            if (CatID != 0)
            {
                blogs = _db.Blogs.Where(a => a.Category_Id == CatID)
                .Include(a => a.Category)
                .Include(a => a.User)
                .Include(a => a.Status)
                .OrderByDescending(a => a.Date_Create)
                .ToList();
            }
            else
            {
                blogs = _db.Blogs.Include(a => a.Category)
                .Include(a => a.User)
                .Include(a => a.Status)
                .OrderByDescending(a => a.Date_Create)
                .ToList();
            }

            //TÌM KIẾM KEYWORD
            if (!String.IsNullOrEmpty(keyWord))
            {
                blogs = blogs.Where(s => s.Title!.ToLower().Contains(keyWord.ToLower())).ToList();
            }

            PagedList<Blog> models = new PagedList<Blog>(blogs.AsQueryable(), pageNumber, pageSize);

            ViewBag.CurrentCateID = CatID;
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "Id", "Value");
            ViewData["category"] = _db.Categories.ToList();
            ViewData["recentBlogs"] = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date_Create).ToList();
            if (keyWord != null) { ViewBag.KeyWord = keyWord; }
            return View(models);
        }

        public IActionResult BlogDetail(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var blog = _db.Blogs.Where(s => s.Id == id).Include(a => a.Category).Include(b => b.User).Include(c => c.Status).FirstOrDefault();
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "Id", "Value");
            ViewData["category"] = _db.Categories.ToList();
            ViewData["recentBlogs"] = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date_Create).ToList();
            return View(blog);
        }


    }
}
