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
    public class QuizsController : Controller
    {
        private readonly LearningDbContext _context;

        public QuizsController(LearningDbContext context)
        {
            _context = context;
        }

        // GET: Quizs
        public async Task<IActionResult> Index()
        {
            var learningDbContext = _context.Quizzes.Include(q => q.QuizLevel).Include(q => q.QuizType).Include(q => q.Topic);
            return View(await learningDbContext.ToListAsync());
        }

        // GET: Quizs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .Include(q => q.QuizLevel)
                .Include(q => q.QuizType)
                .Include(q => q.Topic)
                .FirstOrDefaultAsync(m => m.QuizId == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // GET: Quizs/Create
        public IActionResult Create()
        {
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId");
            ViewData["QuizTypeId"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeId");
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "TopicId");
            return View();
        }

        // POST: Quizs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuizId,Description,Duration,Name,QuestionNum,TopicId,QuizTypeId,QuizLevelId")] Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quiz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", quiz.QuizLevelId);
            ViewData["QuizTypeId"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeId", quiz.QuizTypeId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "TopicId", quiz.TopicId);
            return View(quiz);
        }

        // GET: Quizs/Edit/5
        public async Task<IActionResult> Edit(string id)
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
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", quiz.QuizLevelId);
            ViewData["QuizTypeId"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeId", quiz.QuizTypeId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "TopicId", quiz.TopicId);
            return View(quiz);
        }

        // POST: Quizs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("QuizId,Description,Duration,Name,QuestionNum,TopicId,QuizTypeId,QuizLevelId")] Quiz quiz)
        {
            if (id != quiz.QuizId)
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
                    if (!QuizExists(quiz.QuizId))
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
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", quiz.QuizLevelId);
            ViewData["QuizTypeId"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeId", quiz.QuizTypeId);
            ViewData["TopicId"] = new SelectList(_context.Topics, "TopicId", "TopicId", quiz.TopicId);
            return View(quiz);
        }

        // GET: Quizs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .Include(q => q.QuizLevel)
                .Include(q => q.QuizType)
                .Include(q => q.Topic)
                .FirstOrDefaultAsync(m => m.QuizId == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Quizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);
            _context.Quizzes.Remove(quiz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuizExists(string id)
        {
            return _context.Quizzes.Any(e => e.QuizId == id);
        }
    }
}
