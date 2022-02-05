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

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class PublicFeatureController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public PublicFeatureController(OnlineLearningDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? page)
        {
            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;
            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo BookID mới có thể phân trang.
            var books = _db.Books.Include(b => b.Author).Include(b => b.Category).OrderBy(b => b.BookID);
            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 3;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return View(books.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult BlogList()
        {
            IEnumerable<Blog> blogs;
            Blog_Elements be = new Blog_Elements();
            blogs = _db.Blogs.Include(a => a.Category).Include(a => a.User).Include(a => a.Status).OrderByDescending(a => a.Date);
            var category = _db.Categories;
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
        public async Task<IActionResult> BlogList(string? searchString, int? categoryId)
        {
            var blogs = from m in _db.Blogs
                        select m;
            if (categoryId != null)
            {
                blogs = blogs.Where(s => s.Category_Id == categoryId);
            }
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
