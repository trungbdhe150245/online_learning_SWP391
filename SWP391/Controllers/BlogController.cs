using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP391.Data;
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
            if (CatID != "0")
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
            ViewData["selectedCategory"] = new SelectList(_db.Categories, "Id", "Value");
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
    }
}
