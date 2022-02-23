using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWP391.Models;

namespace SWP391.Data
{
	public class LearningDbContext: IdentityDbContext<AppUser>
	{
		public LearningDbContext(DbContextOptions<LearningDbContext> options): base (options) { }
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
            modelBuilder.Entity<Attempt>(entity => {
                entity.HasKey(a => a.AttemptId);
                entity.HasOne(a => a.User)
                        .WithMany(u => u.Attempts)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(a => a.Quiz)
                        .WithMany(q => q.Attempts)
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<AttemptDetailed>(entity => {
                entity.HasKey(ad => ad.AttemptId);
                entity.HasOne(ad => ad.Attempt)
                        .WithMany(a => a.AttemptDetaileds)
                        .HasForeignKey("AttemptId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.QuestionBank)
                        .WithMany(qb => qb.AttemptDetaileds)
                        .HasForeignKey("QuestionBankId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Blog>(entity => {
                entity.HasKey(b => b.BlogId);
                entity.HasOne(b => b.Status)
                        .WithMany(s => s.Blogs)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(b => b.Category)
                        .WithMany(ct => ct.Blogs)
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(b => b.User)
                        .WithMany(u => u.Blogs)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

            });
            modelBuilder.Entity<Category>(entity => {
                entity.HasKey(ct => ct.CategoryId);
            });
            modelBuilder.Entity<Comment>(entity => {
                entity.HasKey(cm => cm.CommentId);
                entity.HasOne(cm => cm.User)
                        .WithMany(u => u.Comments)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(cm => cm.Blog)
                        .WithMany(b => b.Comments)
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Course>(entity => {
                entity.HasKey(c => c.CourseId);
                entity.HasOne(c => c.Status)
                        .WithMany(s => s.Courses)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(c => c.Category)
                        .WithMany(b => b.Courses)
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<CoursePackage>(entity => {
                entity.HasOne(cp => cp.Course)
                        .WithMany(c => c.CoursePackages)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(cp => cp.PricePackage)
                        .WithMany(pp => pp.CoursePackages)
                        .HasForeignKey("PricePackageId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(cp => new { cp.CourseId, cp.PricePackageId});

            });
            modelBuilder.Entity<Lesson>(entity => {
                entity.HasKey(l => l.LessonId);
                entity.HasOne(l => l.Status)
                        .WithMany(s => s.Lessons)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(l => l.Topic)
                        .WithMany(t => t.Lessons)
                        .HasForeignKey("PricePackageId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Owner>(entity => {
                entity.HasOne(o => o.User)
                        .WithMany(u => u.Owners)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(o => o.Course)
                        .WithMany(c => c.Owners)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(o => new { o.UserId, o.CourseId });
            });
            modelBuilder.Entity<PricePackage>(entity => {
                entity.HasKey(pp => pp.PricePackageId);
                entity.HasOne(pp => pp.Status)
                        .WithMany(s => s.PricePackages)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<QuestionBank>(entity => {
                entity.HasKey(qb => qb.QuestionId);
                entity.HasOne(qb => qb.Status)
                        .WithMany(s => s.QuestionBanks)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(qb => qb.Course)
                        .WithMany(c => c.QuestionBanks)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(qb => qb.QuizLevel)
                        .WithMany(ql => ql.QuestionBanks)
                        .HasForeignKey("QuizLevelId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Quiz>(entity => {
                entity.HasKey(q => q.QuizId);
                entity.HasOne(q => q.QuizType)
                        .WithMany(qt => qt.Quizzes)
                        .HasForeignKey("QuizTypeId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(q => q.QuizLevel)
                        .WithMany(ql => ql.Quizzes)
                        .HasForeignKey("QuizLevelId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(q => q.Course)
                        .WithMany(c => c.Quizzes)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<QuizLevel>(entity => {
                entity.HasKey(ql => ql.QuizLevelId);
            });
            modelBuilder.Entity<QuizType>(entity => {
                entity.HasKey(qt => qt.QuizTypeId);
            });
            modelBuilder.Entity<Slide>(entity => {
                entity.HasKey(sl => sl.SlideId);
                entity.HasOne(sl => sl.Status)
                        .WithMany(s => s.Slides)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Topic>(entity => {
                entity.HasKey(t => t.TopicId);
                entity.HasOne(t => t.Course)
                        .WithMany(c => c.Topics)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<UserCourse>(entity => {
                entity.HasKey(uc => uc.UserCourseId);
                entity.HasOne(uc => uc.Course)
                        .WithMany(c => c.UserCourses)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(uc => uc.User)
                        .WithMany(u => u.UserCourses)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(uc => uc.PricePackage)
                        .WithMany(pp => pp.UserCourses)
                        .HasForeignKey("PricePackageId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<DimensionType>(entity => {
                entity.HasKey(dt => dt.DimensionTypeId);
            });
            modelBuilder.Entity<Dimension>(entity => {
                entity.HasKey(d => d.DimensionId);
                entity.HasOne(d => d.DimensionType)
                        .WithMany(dt => dt.Dimensions)
                        .HasForeignKey("DimensionId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<CourseDimension>(entity => {
                entity.HasOne(cd => cd.Course)
                        .WithMany(c => c.CourseDimensions)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(cd => cd.Dimension)
                        .WithMany(d => d.CourseDimensions)
                        .HasForeignKey("DimensionId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(cd => new { cd.CouresId, cd.DimensionId});
            });
            modelBuilder.Entity<QuestionDimension>(entity => {
                entity.HasOne(qd => qd.QuestionBank)
                        .WithMany(qb => qb.QuestionDimensions)
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(qd => qd.Dimension)
                        .WithMany(d => d.QuestionDimensions)
                        .HasForeignKey("DimensionId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(cd => new { cd.QuestionId, cd.DimensionId });
            });
        }
        public DbSet<Attempt> Attempts { get; set; }
        public DbSet<AttemptDetailed> AttemptDetaileds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursePackage> CoursePackages { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PricePackage> PricePackages { get; set; }
        public DbSet<QuestionBank> QuestionBanks { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizLevel> QuizLevels { get; set; }
        public DbSet<QuizType> QuizTypes { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
		public DbSet<Dimension> Dimensions { get; set; }
		public DbSet<DimensionType> DimensionTypes { get; set; }
		public DbSet<CourseDimension> CourseDimensions { get; set; }
		public DbSet<QuestionDimension> QuestionDimensions { get; set; }
	}
}
