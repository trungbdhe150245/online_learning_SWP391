using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using SWP391.Data;
using SWP391.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SWP391.Controllers
{
    public class BlogController : Controller
    {
        private readonly LearningDbContext _db;
        public BlogController(LearningDbContext db)
        {
            _db = db;
        }

        public IActionResult Filter(int CatID = 0)
        {
            var url = $"/blog/blogList?catID={CatID}";
            if (CatID == 0)
            {
                url = $"/blog/blogList";
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
                blogs = _db.Blogs.Where(a => a.CategoryId == CatID)
                .Include(a => a.Category)
                .Include(a => a.User)
                .Include(a => a.Status)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            }
            else
            {
                blogs = _db.Blogs.Include(a => a.Category)
                .Include(a => a.User)
                .Include(a => a.Status)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            }

            //TÌM KIẾM KEYWORD
            if (!String.IsNullOrEmpty(keyWord))
            {
                blogs = blogs.Where(s => s.Title!.ToLower().Contains(keyWord.ToLower())).ToList();
            }

            PagedList<Blog> models = new PagedList<Blog>(blogs.AsQueryable(), pageNumber, pageSize);

            ViewBag.CurrentCateID = CatID;
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "CategoryId", "CategoryValue");
            ViewData["category"] = _db.Categories.ToList();
            ViewData["recentBlogs"] = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.CreatedDate).ToList();
            if (keyWord != null) { ViewBag.KeyWord = keyWord; }
            return View(models);
        }

        public IActionResult BlogDetail(string? id)
        {
            if (id == "" || id == null)
            {
                return NotFound();
            }
            var blog = _db.Blogs.Where(s => s.BlogId == id).Include(a => a.Category).Include(b => b.User).Include(c => c.Status).FirstOrDefault();
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "Id", "Value");
            ViewData["category"] = _db.Categories.ToList();
            ViewData["recentBlogs"] = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.CreatedDate).ToList();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(string Name, string comment, string BlogID, string UserID)
        {
            if (Name != "" && comment != "")
            {
                var c = new Comment();
                c.CommentId = RandomString(9);
                c.CommentBody = comment.Trim();
                c.BlogId = BlogID;
                c.UserId = UserID;
                _db.Comments.Add(c);
                _db.SaveChanges();
            }
            return Redirect($"/Blog/BlogDetail?id={BlogID}");
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
