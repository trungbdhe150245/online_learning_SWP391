using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using OnlineLearningSWP391.Models;
using SWP391_OnlineLearning_Platform.Models;

namespace OnlineLearningSWP391.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }


            modelBuilder.Entity<Owner>().HasKey(uc => new { uc.UserId, uc.CourseId });

            modelBuilder.Entity<Owner>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<Owner>()
                .HasOne(u => u.Course)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.CourseId);

            modelBuilder.Entity<QuizQuestion>().HasKey(qq => new { qq.QuizId, qq.QuestionId });

            modelBuilder.Entity<QuizQuestion>()
                .HasOne(q => q.Quiz)
                .WithMany(qq => qq.QuizQuestions)
                .HasForeignKey(qi => qi.QuizId);

            modelBuilder.Entity<QuizQuestion>()
                .HasOne(q => q.QuestionBank)
                .WithMany(qq => qq.QuizQuestions)
                .HasForeignKey(qi => qi.QuestionId);

            modelBuilder.Entity<CoursePackage>().HasKey(cp => new { cp.CourseId, cp.PackageId });

            modelBuilder.Entity<CoursePackage>()
                .HasOne(c => c.Course)
                .WithMany(cp => cp.CoursePackages)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<CoursePackage>()
                .HasOne(c => c.PricePackage)
                .WithMany(cp => cp.CoursePackages)
                .HasForeignKey(ci => ci.PackageId);

            modelBuilder.Entity<CourseDimension>().HasKey(cd => new { cd.CourseId, cd.DimensionId });

            modelBuilder.Entity<CourseDimension>()
                .HasOne(c => c.Course)
                .WithMany(cd => cd.CourseDimensions)
                .HasForeignKey(ci => ci.CourseId);
            modelBuilder.Entity<CourseDimension>()
                .HasOne(c => c.Dimension)
                .WithMany(cd => cd.CourseDimensions)
                .HasForeignKey(ci => ci.DimensionId);

            modelBuilder.Entity<QuestionDimension>().HasKey(qd => new { qd.QuestionId, qd.DimensionId });

            modelBuilder.Entity<QuestionDimension>()
                .HasOne(q => q.QuestionBank)
                .WithMany(qd => qd.QuestionDimensions)
                .HasForeignKey(qi => qi.QuestionId);
            modelBuilder.Entity<QuestionDimension>()
                .HasOne(q => q.Dimension)
                .WithMany(qd => qd.QuestionDimensions)
                .HasForeignKey(qi => qi.DimensionId);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Status> Statuss { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<QuizType> QuizTypes { get; set; }

        public DbSet<QuizLevel> QuizLevels { get; set; }

        public DbSet<UserQuiz> UserQuizzes { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<UserCourse> UserCourses { get; set; }

        public DbSet<PricePackage> PricePackages { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Slide> Slides { get; set; }

        public DbSet<QuestionBank> QuestionBanks { get; set; }

        public DbSet<QuizQuestion> QuizQuestions { get; set; }

        public DbSet<CoursePackage> CoursePackages { get; set; }

        public DbSet<Dimension> Dimensions { get; set; }

        public DbSet<DimensionType> DimensionTypes { get; set; }

        public DbSet<CourseDimension> CourseDimensions { get; set; }

        public DbSet<QuestionDimension> QuestionDimensions { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }

}
