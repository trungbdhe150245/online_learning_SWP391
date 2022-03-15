using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP391.Data;
using SWP391.Models;

namespace SWP391.Controllers
{
    public class UserBlogController : Controller
    {
        private readonly LearningDbContext _context;

        public UserBlogController(LearningDbContext context)
        {
            _context = context;
        }

        // GET: UserBlog
        public async Task<IActionResult> Index()
        {
            var learningDbContext = _context.Blogs.Include(b => b.Category).Include(b => b.Slide).Include(b => b.Status).Include(b => b.User);
            return View(await learningDbContext.ToListAsync());
        }

        // GET: UserBlog/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.Category)
                .Include(b => b.Slide)
                .Include(b => b.Status)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: UserBlog/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            ViewData["SlideId"] = new SelectList(_context.Set<Slide>(), "SlideId", "SlideId");
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UserBlog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BlogId,Title,Brief,Content,VideoURL,SlideId,ThumbnailURL,CreatedDate,StatusId,CategoryId,UserId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", blog.CategoryId);
            ViewData["SlideId"] = new SelectList(_context.Set<Slide>(), "SlideId", "SlideId", blog.SlideId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", blog.StatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", blog.UserId);
            return View(blog);
        }

        // GET: UserBlog/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", blog.CategoryId);
            ViewData["SlideId"] = new SelectList(_context.Set<Slide>(), "SlideId", "SlideId", blog.SlideId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", blog.StatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", blog.UserId);
            return View(blog);
        }

        // POST: UserBlog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BlogId,Title,Brief,Content,VideoURL,SlideId,ThumbnailURL,CreatedDate,StatusId,CategoryId,UserId")] Blog blog)
        {
            if (id != blog.BlogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.BlogId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", blog.CategoryId);
            ViewData["SlideId"] = new SelectList(_context.Set<Slide>(), "SlideId", "SlideId", blog.SlideId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", blog.StatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", blog.UserId);
            return View(blog);
        }

        // GET: UserBlog/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.Category)
                .Include(b => b.Slide)
                .Include(b => b.Status)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: UserBlog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(string id)
        {
            return _context.Blogs.Any(e => e.BlogId == id);
        }
    }
}
