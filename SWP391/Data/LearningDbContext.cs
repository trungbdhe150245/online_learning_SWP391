using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWP391.Models;

namespace SWP391.Data
{
    //Using fluentApi
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
                entity.Property(a => a.AttemptId).HasColumnType("varchar(10)");
                entity.Property(a => a.TotalMark).HasColumnType("float");
                entity.Property(a => a.StartTime).HasColumnType("datetime2");

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
                entity.Property(ad => ad.UserAnswer).HasColumnType("text");
                entity.HasOne(ad => ad.Attempt)
                        .WithMany(a => a.AttemptDetaileds)
                        .HasForeignKey("AttemptId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.QuestionBank)
                        .WithMany(qb => qb.AttemptDetaileds)
                        .HasForeignKey("QuestionBankId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(ad => new { ad.AttemptId, ad.QuestionBankId });
            });
            modelBuilder.Entity<Blog>(entity => {
                entity.Property(b => b.BlogId).HasColumnType("varchar(10)");
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
                entity.Property(b => b.Title).HasColumnType("varchar(255)");
                entity.Property(b => b.Brief).HasColumnType("varchar(500)");
                entity.Property(b => b.Content).HasColumnType("text");
                entity.Property(b => b.ThumbnailURL).HasColumnType("varchar(max)");
                entity.Property(b => b.CreatedDate).HasColumnType("datetime2");
            });
            modelBuilder.Entity<Category>(entity => {
                entity.Property(ct => ct.CategoryId).HasColumnType("varchar(10)");
                entity.Property(ct => ct.Value).HasColumnType("varchar(100)");
                entity.HasKey(ct => ct.CategoryId);
            });
            modelBuilder.Entity<Comment>(entity => {
                entity.Property(cm => cm.CommentId).HasColumnType("varchar(10)");
                entity.Property(cm => cm.CommentBody).HasColumnType("text");
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
                entity.Property(c => c.CourseId).HasColumnType("varchar(10)");
                entity.Property(c => c.CreatedDate).HasColumnType("datetime2");
				entity.Property(c => c.Description).HasColumnType("text");
                entity.Property(c => c.ShortDescription).HasColumnType("varchar(500)");
                entity.Property(c => c.Title).HasColumnType("varchar(255)");
                entity.Property(c => c.ThumbnailURL).HasColumnType("text");
				entity.HasKey(c => c.CourseId);
                entity.HasOne(c => c.Status)
                        .WithMany(s => s.Courses)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(c => c.Category)
                        .WithMany(b => b.Courses)
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(c => c.Featured)
                        .WithMany(b => b.Courses)
                        .HasForeignKey("FeaturedId")
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
                entity.Property(l => l.LessonId).HasColumnType("varchar(10)");
                entity.Property(l => l.LessonName).HasColumnType("varchar(255)");
                entity.Property(l => l.LessonOrder).HasColumnType("int");
                entity.Property(l => l.HtmlContent).HasColumnType("text");
                entity.Property(l => l.VideoURL).HasColumnType("text");
                entity.HasKey(l => l.LessonId);
                //entity.HasOne(l => l.Status)
                //        .WithMany(s => s.Lessons)
                //        .HasForeignKey("StatusId")
                //        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(l => l.Topic)
                        .WithMany(t => t.Lessons)
                        .HasForeignKey("PricePackageId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<CourseOwner>(entity => {
                entity.Property(co => co.PurchaseTime).HasColumnType("datetime2");
                entity.HasOne(co => co.User)
                        .WithMany(u => u.CourseOwners)
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(co => co.Course)
                        .WithMany(c => c.CourseOwners)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(o => new { o.UserId, o.CourseId });
            });
            modelBuilder.Entity<Status>(entity => {
                entity.Property(s => s.StatusId).HasColumnType("varchar(10)");
                entity.Property(s => s.Value).HasColumnType("varchar(255)");
                entity.HasKey(s => s.StatusId);
            });
            modelBuilder.Entity<PricePackage>(entity => {
                entity.Property(pp => pp.PricePackageId).HasColumnType("varchar(10)");
                entity.Property(pp => pp.Name).HasColumnType("varchar(255)");
                entity.Property(pp => pp.Description).HasColumnType("text");
                entity.Property(pp => pp.Price).HasColumnType("float");
                entity.Property(pp => pp.Duration).HasColumnType("int");
                entity.Property(pp => pp.StartTime).HasColumnType("datetime2");
                entity.HasKey(pp => pp.PricePackageId);
                entity.HasOne(pp => pp.Status)
                        .WithMany(s => s.PricePackages)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<QuestionBank>(entity => {
                entity.Property(qb => qb.QuestionId).HasColumnType("varchar(10)");
                entity.Property(qb => qb.Answer).HasColumnType("text");
                entity.Property(qb => qb.Content).HasColumnType("text");
                entity.Property(qb => qb.Explanation).HasColumnType("text");
                entity.Property(qb => qb.Weight).HasColumnType("float");
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
                entity.Property(q => q.QuizId).HasColumnType("varchar(10)");
                entity.Property(q => q.Description).HasColumnType("text");
                entity.Property(q => q.Duration).HasColumnType("int");
                entity.Property(q => q.Name).HasColumnType("varchar(255)");
                entity.Property(q => q.QuestionNum).HasColumnType("int");
                entity.HasKey(q => q.QuizId);
                entity.HasOne(q => q.QuizType)
                        .WithMany(qt => qt.Quizzes)
                        .HasForeignKey("QuizTypeId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(q => q.QuizLevel)
                        .WithMany(ql => ql.Quizzes)
                        .HasForeignKey("QuizLevelId")
                        .OnDelete(DeleteBehavior.NoAction);
                //*******
                entity.HasOne(q => q.Topic)
                        .WithMany(t => t.Quizzes)
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.NoAction);
                //*******
                //entity.HasOne(q => q.Course)
                //        .WithMany(c => c.Quizzes)
                //        .HasForeignKey("CourseId")
                //        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<QuizLevel>(entity => {
                entity.Property(ql => ql.QuizLevelId).HasColumnType("varchar(10)");
                entity.Property(ql => ql.Name).HasColumnType("varchar(255)");
                entity.HasKey(ql => ql.QuizLevelId);
            });
            modelBuilder.Entity<QuizType>(entity => {
                entity.Property(qt => qt.QuizTypeId).HasColumnType("varchar(10)");
                entity.Property(qt => qt.Name).HasColumnType("varchar(255)");
                entity.HasKey(qt => qt.QuizTypeId);
            });
            modelBuilder.Entity<Slide>(entity => {
                entity.Property(sl => sl.SlideId).HasColumnType("varchar(10)") ;
                entity.Property(sl => sl.Title).HasColumnType("varchar(255)");
                entity.Property(sl => sl.CourseURL).HasColumnType("text");
                entity.Property(sl => sl.ThumbnailURL).HasColumnType("text");
                entity.Property(sl => sl.Description).HasColumnType("text");
                entity.HasKey(sl => sl.SlideId);
                entity.HasOne(sl => sl.Status)
                        .WithMany(s => s.Slides)
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Topic>(entity => {
                entity.Property(t => t.TopicId).HasColumnType("varchar(10)");
                entity.Property(t => t.TopicName).HasColumnType("varchar(255)");
                entity.Property(t => t.TopicOrder).HasColumnType("int");
                entity.HasKey(t => t.TopicId);
                entity.HasOne(t => t.Course)
                        .WithMany(c => c.Topics)
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<UserCourse>(entity => {
                entity.Property(uc => uc.UserCourseId).HasColumnType("varchar(10)");
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
            modelBuilder.Entity<QuizQuestion>(entity => {
                entity.HasOne(qq => qq.Quiz)
                        .WithMany(q => q.QuizQuestions)
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(qq => qq.QuestionBank)
                        .WithMany(qb => qb.QuizQuestions)
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction);
                entity.HasKey(qq => new { qq.QuizId, qq.QuestionId });
            });
            modelBuilder.Entity<Featured>(entity => {
                entity.Property(f => f.FeaturedId).HasColumnType("varchar(10)");
                entity.Property(f => f.Value).HasColumnType("varchar(255)");
                entity.HasKey(f => f.FeaturedId);
            });
            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(pk => pk.PackageId).HasColumnType("varchar(10)");
                entity.Property(pk => pk.PackageName).HasColumnType("varchar(255)");
                entity.Property(pk => pk.PackageDescription).HasColumnType("varchar(max)");
                entity.Property(pk => pk.PackagePrice).HasColumnType("int");
                entity.HasKey(pk => pk.PackageId);

            });
        }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Attempt> Attempts { get; set; }
        public DbSet<AttemptDetailed> AttemptDetaileds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursePackage> CoursePackages { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<CourseOwner> CourseOwners { get; set; }
        public DbSet<PricePackage> PricePackages { get; set; }
        public DbSet<QuestionBank> QuestionBanks { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizLevel> QuizLevels { get; set; }
        public DbSet<QuizType> QuizTypes { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
		public DbSet<QuizQuestion> QuizQuestions { get; set; }
	}
}
