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
            //List<QuestionBank> questions = new List<QuestionBank>();
            //questions = _context.Question_Banks.Include(q => q.Course).Include(q => q.Quiz_Level).Include(q => q.Status).ToList();
            ////SEARCHING
            //if (!String.IsNullOrEmpty(keyWord))
            //{
            //    questions = questions.Where(s => s.Content!.ToLower().Contains(keyWord.ToLower())).ToList();
            //}
            ////SORTED
            //ViewData["content"] = String.IsNullOrEmpty(sortOrder) ? "yes" : "";
            //ViewData["level"] = sortOrder == "high" ? "low" : "high";

            //switch (sortOrder)
            //{
            //    case "yes":
            //        questions = questions.OrderByDescending(s => s.Content).ToList();
            //        break;
            //    case "low":
            //        questions = questions.OrderBy(s => s.Quiz_Level.Id).ToList();
            //        break;
            //    case "high":
            //        questions = questions.OrderByDescending(s => s.Quiz_Level.Id).ToList();
            //        break;
            //    default:
            //        questions = questions.OrderBy(s => s.Content).ToList();
            //        break;
            //}
            //return View(questions);

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
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description");
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "Id", "Name");
            ViewData["Status_Id"] = new SelectList(_context.Status, "Id", "Value");
            return View();
        }

        // POST: Admin/QuestionBank/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Answer,Content,Explanation,Course_Id,Level_Id,Status_Id")] QuestionBank QuestionBank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(QuestionBank);
                await _context.SaveChangesAsync();
                return RedirectToAction("QuestionList");
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", QuestionBank.CourseId);
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "Id", "Name", QuestionBank.QuizLevelId);
            ViewData["Status_Id"] = new SelectList(_context.Status, "Id", "Value", QuestionBank.StatusId);
            return View(QuestionBank);
        }

        // GET: Admin/QuestionBank/QuestionDetail/5
        public async Task<IActionResult> QuestionDetail(int? id)
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
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", QuestionBank.CourseId);
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "Id", "Name", QuestionBank.QuizLevelId);
            ViewData["Status_Id"] = new SelectList(_context.Status, "Id", "Value", QuestionBank.StatusId);
            return View(QuestionBank);
        }

        // POST: Admin/QuestionBank/QuestionDetail/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> QuestionDetail(string id, [Bind("Id,Answer,Content,Explanation,Course_Id,Level_Id,Status_Id,OptionA,OptionB,OptionC,OptionD")] QuestionBank QuestionBank)
        {
            //THAY ĐỔI CÂU HỎI THEO LEVEL





            if (id != QuestionBank.QuestionId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(QuestionBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Question_BankExists(QuestionBank.QuestionId))
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
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", QuestionBank.CourseId);
            ViewData["Level_Id"] = new SelectList(_context.QuizLevels, "Id", "Name", QuestionBank.QuizLevelId);
            ViewData["Status_Id"] = new SelectList(_context.Status, "Id", "Value", QuestionBank.StatusId);
            return View(QuestionBank);
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
