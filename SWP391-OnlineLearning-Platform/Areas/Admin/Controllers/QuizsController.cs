using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using SWP391_OnlineLearning_Platform.Models.ViewModels;

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
            return View(Filter(key, page));
        }
        public IEnumerable<Quiz> Filter(string key, int page)
        {
            IEnumerable<Quiz> quizs = _context.Quizzes.Include(q => q.Course).Include(q => q.Quiz_Level).Include(q => q.Quiz_Type);
            if (!string.IsNullOrEmpty(key))
            {
                quizs = quizs.Where(s => s.Name!.ToLower().Contains(key.ToLower()));
            }
            const int pageSize = 10;
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
        public async Task<IActionResult> QuizDetails(int? id)
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
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", quiz.Quiz_Level_Id);

            //KIỂM TRA TRONG DATABASE XEM QUIZ ĐÃ TẠO DANH SÁCH QUESTION CHƯA 
            var questions = (from s in _context.Quiz_Questions
                            join k in _context.Question_Banks on s.Question_Id equals k.Id
                            where s.Quiz_Id == id
                            select k).ToList();

            Quiz_QuestionVM quiz_QuestionVM = new Quiz_QuestionVM();
            quiz_QuestionVM.quiz = quiz;
            quiz_QuestionVM.list_question = questions;
            return View(quiz_QuestionVM);
        }

        // GET: Admin/Quizs/Create
        public IActionResult Create()
        {
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Title");
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name");
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name");
            return View();
        }

        // POST: Admin/Quizs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Duration,Name,Number_question,Pass_rate,Course_Id,Quiz_Level_Id,Quiz_Type_Id")] Quiz quiz)
        {


            if (ModelState.IsValid)
            {
                _context.Add(quiz);
                await _context.SaveChangesAsync();
                //TẠO CÂU HỎI TỪ QUESTION BANK (THEO LEVEL, COURSE)
                int quiz_id = ((from s in _context.Quizzes select s.Id).Max()) + 1;
                GenerateQuestion(quiz.Quiz_Level_Id, quiz.Number_question, quiz.Id);

                return RedirectToAction(nameof(Index));
            }
            ViewData["Course_Id"] = new SelectList(_context.Courses, "Id", "Description", quiz.Course_Id);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.Quiz_Levels, "Id", "Name", quiz.Quiz_Level_Id);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.Quiz_Types, "Id", "Name", quiz.Quiz_Type_Id);


            return View(quiz);
        }

        public async void GenerateQuestion(int quiz_level, int numberOfQuestion, int quiz_id)
        {
            //int easy = 0, medium = 0, hard = 0;
            //switch (quiz_level)
            //{
            //    case 1://dễ (70%easy,20%medium,10%hard)
            //        //lấy câu hỏi từ quesiton bank
            //        easy = (int)Math.Round(numberOfQuestion * 0.7, 0);
            //        medium = (int)Math.Round(numberOfQuestion * 0.2, 0);
            //        hard = (int)Math.Round(numberOfQuestion * 0.1, 0);
            //        break;
            //    case 2://trung bình (50%easy,30%medium,20%hard)
            //        //lấy câu hỏi từ quesiton bank
            //        easy = (int)Math.Round(numberOfQuestion * 0.5, 0);
            //        medium = (int)Math.Round(numberOfQuestion * 0.3, 0);
            //        hard = (int)Math.Round(numberOfQuestion * 0.2, 0);
            //        break;
            //    case 3://khó (30%,40%,30%)
            //        //lấy câu hỏi từ quesiton bank
            //        easy = (int)Math.Round(numberOfQuestion * 0.3, 0);
            //        medium = (int)Math.Round(numberOfQuestion * 0.4, 0);
            //        hard = (int)Math.Round(numberOfQuestion * 0.3, 0);
            //        break;
            //    default:
            //        break;
            //}
            //var questionEasy = (from s in _context.Question_Banks where s.Level_Id == 1 select s);
            //var questionMedium = (from s in _context.Question_Banks where s.Level_Id == 2 select s);
            //var questionHard = (from s in _context.Question_Banks where s.Level_Id == 3 select s);

            IList<Question_Bank> temp = (from s in _context.Question_Banks select s).Take(numberOfQuestion).ToList();
            foreach (var item in temp)
            {
                _context.Add(new Quiz_Question
                {
                    Question_Id = item.Id,
                    Quiz_Id = quiz_id
                });
                _context.SaveChanges();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void CreateQuiz_Question([Bind("Quiz_Id,Question_Id")] Quiz_Question quiz_Question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quiz_Question);
            }
            ViewData["Question_Id"] = new SelectList(_context.Question_Banks, "Id", "Answer", quiz_Question.Question_Id);
            ViewData["Quiz_Id"] = new SelectList(_context.Quizzes, "Id", "Description", quiz_Question.Quiz_Id);
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
