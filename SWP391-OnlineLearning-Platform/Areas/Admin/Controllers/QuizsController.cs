using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;

namespace SWP391_OnlineLearning_Platform.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuizsController : Controller
    {
        private readonly OnlineLearningDbContext _context;

        public QuizsController(OnlineLearningDbContext context)
        {
            _context = context;

        }

        // GET: Admin/Quizs
        public async Task<IActionResult> Index(string key, int page)
        {
            return View(Filter(key,page));

        }
        public IEnumerable<Quiz> Filter(string key, int page)
        {
            
            IEnumerable<Quiz> quizs = _context.Quizzes.Include(q => q.Course).Include(q => q.Quiz_Level).Include(q => q.Quiz_Type);

            if (!string.IsNullOrEmpty(key))
            {
                quizs = quizs.Where(s => s.Name!.ToLower().Contains(key.ToLower()));
            }
            

            const int pageSize = 1;
            if (page < 1)
            {
                page = 1;
            }

            int resCount = quizs.Count();
            var pager = new Paginated(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;

            var data = quizs.Skip(recSkip).Take(pager.PageSize);
            this.ViewBag.Paginated = pager;
            return data;
        }


        // GET: Admin/Quizs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .Include(q => q.Course)
                .Include(q => q.Quiz_Level)
                .Include(q => q.Quiz_Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // GET: Admin/Quizs/Create
        public IActionResult Create()
        {
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description");
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name");
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name");
            return View();
        }

        // POST: Admin/Quizs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Duration,Name,Number_question,Pass_rate,Course_Id,Quiz_Level_Id,Quiz_Type_Id")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quiz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", quiz.Course_Id);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", quiz.Quiz_Level_Id);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name", quiz.Quiz_Type_Id);
            return View(quiz);
        }

        // GET: Admin/Quizs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes.FindAsync(id);
            if (quiz == null)
            {
                return NotFound();
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", quiz.Course_Id);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", quiz.Quiz_Level_Id);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name", quiz.Quiz_Type_Id);
            return View(quiz);
        }

        // POST: Admin/Quizs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Duration,Name,Number_question,Pass_rate,Course_Id,Quiz_Level_Id,Quiz_Type_Id")] Quiz quiz)
        {
            if (id != quiz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quiz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuizExists(quiz.Id))
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
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", quiz.Course_Id);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", quiz.Quiz_Level_Id);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name", quiz.Quiz_Type_Id);
            return View(quiz);
        }

        // GET: Admin/Quizs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .Include(q => q.Course)
                .Include(q => q.Quiz_Level)
                .Include(q => q.Quiz_Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Admin/Quizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);
            _context.Quizzes.Remove(quiz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuizExists(int id)
        {
            return _context.Quizzes.Any(e => e.Id == id);
        }
    }
}
