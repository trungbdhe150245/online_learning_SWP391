using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP391.Data;
using SWP391.Models;
using SWP391.Models.ViewModels;

namespace SWP391.Areas.Admin.Controllers
{
    public class QuizsController : Controller
    {
        private readonly LearningDbContext _context;

        public QuizsController(LearningDbContext context)
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
            IEnumerable<Quiz> quizs = _context.Quizzes.Include(q => q.Topic).Include(q => q.QuizLevel).Include(q => q.QuizType);
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
        public async Task<IActionResult> QuizDetails(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var quiz = await _context.Quizzes
                .Include(q => q.Topic)
                .Include(q => q.QuizLevel)
                .Include(q => q.QuizType)
                .FirstOrDefaultAsync(m => m.QuizId == id);
            if (quiz == null)
            {
                return NotFound();
            }
            ViewData["Quiz_Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", quiz.QuizLevelId);

            //KIỂM TRA TRONG DATABASE XEM QUIZ ĐÃ TẠO DANH SÁCH QUESTION CHƯA 
            var questions = (from s in _context.QuizQuestions
                            join k in _context.QuestionBanks on s.QuestionId equals k.QuestionId
                            where s.QuizId == id
                            select k).Include(q => q.Status).ToList();

            Quiz_QuestionVM quiz_QuestionVM = new Quiz_QuestionVM();
            quiz_QuestionVM.quiz = quiz;
            quiz_QuestionVM.list_question = questions;
            return View(quiz_QuestionVM);
        }

        // GET: Admin/Quizs/Create
        public IActionResult Create()
        {
            ViewData["Topic_Id"] = new SelectList(_context.Topics, "TopicId", "TopicName");
            ViewData["Quiz_Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName");
            ViewData["Quiz_Type_Id"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeName");
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
                GenerateQuestion(quiz.QuizLevelId, quiz.QuestionNum, RandomID().ToString());

                return RedirectToAction(nameof(Index));
            }
            ViewData["Topic_Id"] = new SelectList(_context.Topics, "TopicId", "TopicName", quiz.TopicId);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", quiz.QuizLevelId);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeName", quiz.QuizLevelId);

            return View(quiz);
        }

        private readonly Random _random = new Random();
        public int RandomID()
        {
            return _random.Next(10000, 99999);
        }


        public async void GenerateQuestion(int quiz_level, int numberOfQuestion, string quiz_id)
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

            IList<QuestionBank> temp = _context.QuestionBanks.Take(numberOfQuestion).ToList();
            foreach (var item in temp)
            {
                _context.Add(new QuizQuestion
                {
                    QuestionId = item.QuestionId,
                    QuizId = quiz_id
                });
                _context.SaveChanges();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void CreateQuiz_Question([Bind("Quiz_Id,Question_Id")] QuizQuestion quiz_Question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quiz_Question);
            }
            ViewData["Question_Id"] = new SelectList(_context.QuestionBanks, "Id", "Answer", quiz_Question.QuestionId);
            ViewData["Quiz_Id"] = new SelectList(_context.Quizzes, "Id", "Description", quiz_Question.QuizId);
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
            ViewData["Topic_Id"] = new SelectList(_context.Topics, "TopicId", "TopicName", quiz.TopicId);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", quiz.QuizLevelId);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeName", quiz.QuizLevelId);
            return View(quiz);
        }

        // POST: Admin/Quizs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Description,Duration,Name,Number_question,Pass_rate,Course_Id,Quiz_Level_Id,Quiz_Type_Id")] Quiz quiz)
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
            ViewData["Topic_Id"] = new SelectList(_context.Topics, "TopicId", "TopicName", quiz.TopicId);
            ViewData["Quiz_Level_Id"] = new SelectList(_context.QuizLevels, "QuizLevelId", "QuizLevelName", quiz.QuizLevelId);
            ViewData["Quiz_Type_Id"] = new SelectList(_context.QuizTypes, "QuizTypeId", "QuizTypeName", quiz.QuizLevelId);
            return View(quiz);
        }

        // GET: Admin/Quizs/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = await _context.Quizzes
                .Include(q => q.Topic)
                .Include(q => q.QuizLevel)
                .Include(q => q.QuizType)
                .FirstOrDefaultAsync(m => m.QuizId == id);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Admin/Quizs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var quiz = await _context.Quizzes.FindAsync(id);
            var quesiton_find_in_qq = _context.QuizQuestions.Where(x => x.QuizId == id).ToList();
            foreach (var item in quesiton_find_in_qq)
            {
                _context.QuizQuestions.Remove(item);
            }
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
