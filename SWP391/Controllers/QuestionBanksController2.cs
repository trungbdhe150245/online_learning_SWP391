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
    public class QuestionBanksController2 : Controller
    {
        private readonly LearningDbContext _context;

        public QuestionBanksController2(LearningDbContext context)
        {
            _context = context;
        }

        // GET: QuestionBanksController2
        public async Task<IActionResult> Index()
        {
            var learningDbContext = _context.QuestionBanks.Include(q => q.Course).Include(q => q.QuizLevel).Include(q => q.Status);
            return View(await learningDbContext.ToListAsync());
        }

        // GET: QuestionBanksController2/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBanks
                .Include(q => q.Course)
                .Include(q => q.QuizLevel)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        // GET: QuestionBanksController2/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId");
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId");
            return View();
        }

        // POST: QuestionBanksController2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionId,Answer,Content,Explanation,Weight,QuizLevelId,CourseId,OptionA,OptionB,OptionC,OptionD,StatusId")] QuestionBank questionBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", questionBank.CourseId);
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", questionBank.QuizLevelId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", questionBank.StatusId);
            return View(questionBank);
        }

        // GET: QuestionBanksController2/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBanks.FindAsync(id);
            if (questionBank == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", questionBank.CourseId);
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", questionBank.QuizLevelId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", questionBank.StatusId);
            return View(questionBank);
        }

        // POST: QuestionBanksController2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("QuestionId,Answer,Content,Explanation,Weight,QuizLevelId,CourseId,OptionA,OptionB,OptionC,OptionD,StatusId")] QuestionBank questionBank)
        {
            if (id != questionBank.QuestionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionBankExists(questionBank.QuestionId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", questionBank.CourseId);
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", questionBank.QuizLevelId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", questionBank.StatusId);
            return View(questionBank);
        }

        // GET: QuestionBanksController2/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionBank = await _context.QuestionBanks
                .Include(q => q.Course)
                .Include(q => q.QuizLevel)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (questionBank == null)
            {
                return NotFound();
            }

            return View(questionBank);
        }

        // POST: QuestionBanksController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var questionBank = await _context.QuestionBanks.FindAsync(id);
            _context.QuestionBanks.Remove(questionBank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionBankExists(string id)
        {
            return _context.QuestionBanks.Any(e => e.QuestionId == id);
        }
    }
}
