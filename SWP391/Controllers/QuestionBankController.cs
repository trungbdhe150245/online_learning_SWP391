using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using SWP391.Data;
using SWP391.Models;

namespace SWP391.Controllers
{
    public class QuestionBankController : Controller
    {
        private readonly LearningDbContext _context;

        public QuestionBankController(LearningDbContext context)
        {
            _context = context;
        }

        // GET: Admin/QuestionBank
        public async Task<IActionResult> QuestionList(string key, string sortOrder, int page)
        {
            return View(Filter(key, sortOrder, page));
        }
        public IEnumerable<QuestionBank> Filter(string key, string sortOrder, int page)
        {
            ViewData["content"] = String.IsNullOrEmpty(sortOrder) ? "yes" : "";
            ViewData["level"] = sortOrder == "high" ? "low" : "high";
            IEnumerable<QuestionBank> questions = _context.QuestionBanks.Include(q => q.Course).Include(q => q.QuizLevel).Include(q => q.Status);

            if (!string.IsNullOrEmpty(key))
            {
                questions = questions.Where(s => s.Content!.ToLower().Contains(key.ToLower()));
            }
            switch (sortOrder)
            {
                case "yes":
                    questions = questions.OrderByDescending(s => s.Content).ToList();
                    break;
                case "low":
                    questions = questions.OrderBy(s => s.QuizLevel.QuizLevelId).ToList();
                    break;
                case "high":
                    questions = questions.OrderByDescending(s => s.QuizLevel.QuizLevelId).ToList();
                    break;
                default:
                    questions = questions.OrderBy(s => s.Content).ToList();
                    break;
            }
            const int pageSize = 4;
            if (page < 1)
            {
                page = 1;
            }
            int resCount = questions.Count();
            var pager = new Paginated(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;

            var data = questions.Skip(recSkip).Take(pager.PageSize);
            this.ViewBag.Paginated = pager;
            return data;
        }



        // GET: Admin/QuestionBank/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var QuestionBank = await _context.QuestionBanks
                .Include(q => q.Course)
                .Include(q => q.QuizLevel)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (QuestionBank == null)
            {
                return NotFound();
            }

            return View(QuestionBank);
        }

        // GET: Admin/QuestionBank/Create
        public IActionResult Create()
        {
            ViewData["Course_Id"] = new SelectList(_context.Courses, "CourseId", "Title");
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName");
            ViewData["Status_Id"] = new SelectList(_context.Status, "StatusId", "StatusValue");
            return View();
        }

        // POST: Admin/QuestionBank/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionId,Answer,Content,Explanation,Weight,QuizLevelId,CourseId,OptionA,OptionB,OptionC,OptionD,StatusId")] QuestionBank questionBank)
        {
            if (ModelState.IsValid)
            {
                //Them ID ngau nhien
                questionBank.QuestionId = RandomID().ToString();

                _context.Add(questionBank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", questionBank.CourseId);
            ViewData["QuizLevelId"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelId", questionBank.QuizLevelId);
            ViewData["StatusId"] = new SelectList(_context.Status, "StatusId", "StatusId", questionBank.StatusId);
            return View(questionBank);
        }

        private readonly Random _random = new Random();
        public int RandomID()
        {
            return _random.Next(10000, 99999);
        }

        // GET: Admin/QuestionBank/QuestionDetail/5
        public async Task<IActionResult> QuestionDetail(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var QuestionBank = await _context.QuestionBanks.FindAsync(id);
            if (QuestionBank == null)
            {
                return NotFound();
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "CourseId", "Title", QuestionBank.CourseId);
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", QuestionBank.QuizLevelId);
            ViewData["Status_Id"] = new SelectList(_context.Status, "StatusId", "StatusValue", QuestionBank.StatusId);
            return View(QuestionBank);
        }

        // POST: Admin/QuestionBank/QuestionDetail/5
        [HttpPost]
        public async Task<IActionResult> QuestionDetail(string id, [Bind("QuestionId,Answer,Content,Explanation,Weight,QuizLevelId,CourseId,OptionA,OptionB,OptionC,OptionD,StatusId")] QuestionBank questionBank)
        {
            //THAY ĐỔI CÂU HỎI THEO LEVEL

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
                    if (!Question_BankExists(questionBank.QuestionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("QuestionList");
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "CourseId", "Title", questionBank.CourseId);
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", questionBank.QuizLevelId);
            ViewData["Status_Id"] = new SelectList(_context.Status, "StatusId", "StatusValue", questionBank.StatusId);
            return View(questionBank);
        }

        // GET: Admin/QuestionBank/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var QuestionBank = await _context.QuestionBanks
                .Include(q => q.Course)
                .Include(q => q.QuizLevel)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (QuestionBank == null)
            {
                return NotFound();
            }

            return View(QuestionBank);
        }

        // POST: Admin/QuestionBank/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var QuestionBank = await _context.QuestionBanks.FindAsync(id);
            var quesiton_find_in_qq = _context.QuizQuestions.Where(x => x.QuestionId == id).ToList();
            foreach (var item in quesiton_find_in_qq)
            {
                _context.QuizQuestions.Remove(item);
            }
            _context.QuestionBanks.Remove(QuestionBank);
            await _context.SaveChangesAsync();
            return RedirectToAction("QuestionList");
        }

        //xử lý file import:
        public IActionResult Import()
        {
            return View();
        }

        private bool Question_BankExists(string id)
        {
            return _context.QuestionBanks.Any(e => e.QuestionId == id);
        }
    }
}
