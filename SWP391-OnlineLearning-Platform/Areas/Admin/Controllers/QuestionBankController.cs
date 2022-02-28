using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;

namespace SWP391_OnlineLearning_Platform.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionBankController : Controller
    {
        private readonly OnlineLearningDbContext _context;

        public QuestionBankController(OnlineLearningDbContext context)
        {
            _context = context;
        }

        // GET: Admin/QuestionBank
        public async Task<IActionResult> QuestionList(string key, string sortOrder, int page)
        {
            //List<Question_Bank> questions = new List<Question_Bank>();
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
        public IEnumerable<Question_Bank> Filter(string key, string sortOrder, int page)
        {
            ViewData["content"] = String.IsNullOrEmpty(sortOrder) ? "yes" : "";
            ViewData["level"] = sortOrder == "high" ? "low" : "high";
            IEnumerable<Question_Bank> questions = _context.Question_Banks.Include(q => q.Course).Include(q => q.Quiz_Level).Include(q => q.Status);

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
                    questions = questions.OrderBy(s => s.Quiz_Level.Id).ToList();
                    break;
                case "high":
                    questions = questions.OrderByDescending(s => s.Quiz_Level.Id).ToList();
                    break;
                default:
                    questions = questions.OrderBy(s => s.Content).ToList();
                    break;
            }
            const int pageSize = 2;
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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question_Bank = await _context.Question_Banks
                .Include(q => q.Course)
                .Include(q => q.Quiz_Level)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question_Bank == null)
            {
                return NotFound();
            }

            return View(question_Bank);
        }

        // GET: Admin/QuestionBank/Create
        public IActionResult Create()
        {
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description");
            ViewData["Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name");
            ViewData["Status_Id"] = new SelectList(_context.Statuss, "Id", "Value");
            return View();
        }

        // POST: Admin/QuestionBank/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Answer,Content,Explanation,Course_Id,Level_Id,Status_Id")] Question_Bank question_Bank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question_Bank);
                await _context.SaveChangesAsync();
                return RedirectToAction("QuestionList");
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", question_Bank.Course_Id);
            ViewData["Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", question_Bank.Level_Id);
            ViewData["Status_Id"] = new SelectList(_context.Statuss, "Id", "Value", question_Bank.Status_Id);
            return View(question_Bank);
        }

        // GET: Admin/QuestionBank/QuestionDetail/5
        public async Task<IActionResult> QuestionDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question_Bank = await _context.Question_Banks.FindAsync(id);
            if (question_Bank == null)
            {
                return NotFound();
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", question_Bank.Course_Id);
            ViewData["Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", question_Bank.Level_Id);
            ViewData["Status_Id"] = new SelectList(_context.Statuss, "Id", "Value", question_Bank.Status_Id);
            return View(question_Bank);
        }

        // POST: Admin/QuestionBank/QuestionDetail/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> QuestionDetail(int id, [Bind("Id,Answer,Content,Explanation,Course_Id,Level_Id,Status_Id")] Question_Bank question_Bank)
        {
            if (id != question_Bank.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question_Bank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Question_BankExists(question_Bank.Id))
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
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", question_Bank.Course_Id);
            ViewData["Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", question_Bank.Level_Id);
            ViewData["Status_Id"] = new SelectList(_context.Statuss, "Id", "Value", question_Bank.Status_Id);
            return View(question_Bank);
        }

        // GET: Admin/QuestionBank/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question_Bank = await _context.Question_Banks
                .Include(q => q.Course)
                .Include(q => q.Quiz_Level)
                .Include(q => q.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question_Bank == null)
            {
                return NotFound();
            }

            return View(question_Bank);
        }

        // POST: Admin/QuestionBank/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question_Bank = await _context.Question_Banks.FindAsync(id);
            _context.Question_Banks.Remove(question_Bank);
            await _context.SaveChangesAsync();
            return RedirectToAction("QuestionList");
        }

        //xử lý file import:
        public IActionResult Import()
        {
            return View();
        }

        private bool Question_BankExists(int id)
        {
            return _context.Question_Banks.Any(e => e.Id == id);
        }
    }
}
