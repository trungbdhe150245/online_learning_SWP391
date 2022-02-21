using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SWP391_OnlineLearning_Platform.Data
{
    public class OnlineLearningDbContext : IdentityDbContext<AppUser>
    {
        public OnlineLearningDbContext(DbContextOptions<OnlineLearningDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User_Role>().HasKey(ur => new { ur.Role_Id, ur.User_Id });

            //modelBuilder.Entity<User_Role>()
            //    .HasOne(u => u.User)
            //    .WithMany(ur => ur.User_Roles)
            //    .HasForeignKey(ui => ui.User_Id);

            //modelBuilder.Entity<User_Role>()
            //    .HasOne(u => u.Role)
            //    .WithMany(ur => ur.User_Roles)
            //    .HasForeignKey(ui => ui.Role_Id);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            modelBuilder.Entity<Owner>().HasKey(uc => new { uc.User_Id, uc.Course_Id });
            
            modelBuilder.Entity<Owner>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.User_Id);

            modelBuilder.Entity<Owner>()
                .HasOne(u => u.Course)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.Course_Id);

            modelBuilder.Entity<Quiz_Question>().HasKey(qq => new { qq.Quiz_Id, qq.Question_Id });

            modelBuilder.Entity<Quiz_Question>()
                .HasOne(q => q.Quiz)
                .WithMany(qq => qq.Quiz_Questions)
                .HasForeignKey(qi => qi.Quiz_Id);

            modelBuilder.Entity<Quiz_Question>()
                .HasOne(q => q.Question_Bank)
                .WithMany(qq => qq.Quiz_Questions)
                .HasForeignKey(qi => qi.Question_Id);

            modelBuilder.Entity<Course_Package>().HasKey(cp => new { cp.Course_Id, cp.Package_Id });

            modelBuilder.Entity<Course_Package>()
                .HasOne(c => c.Course)
                .WithMany(cp => cp.Course_Packages)
                .HasForeignKey(ci => ci.Course_Id);

            modelBuilder.Entity<Course_Package>()
                .HasOne(c => c.Price_Package)
                .WithMany(cp => cp.Course_Packages)
                .HasForeignKey(ci => ci.Package_Id);

            modelBuilder.Entity<Course_Dimension>().HasKey(cd => new { cd.Course_Id, cd.Dimension_Id });

            modelBuilder.Entity<Course_Dimension>()
                .HasOne(c => c.Course)
                .WithMany(cd => cd.Course_Dimensions)
                .HasForeignKey(ci => ci.Course_Id);
            modelBuilder.Entity<Course_Dimension>()
                .HasOne(c => c.Dimension)
                .WithMany(cd => cd.Course_Dimensions)
                .HasForeignKey(ci => ci.Dimension_Id);

            modelBuilder.Entity<Question_Dimension>().HasKey(qd => new { qd.Question_Id, qd.Dimension_Id });

            modelBuilder.Entity<Question_Dimension>()
                .HasOne(q => q.Question_Bank)
                .WithMany(qd => qd.Question_Dimensions)
                .HasForeignKey(qi => qi.Question_Id);
            modelBuilder.Entity<Question_Dimension>()
                .HasOne(q => q.Dimension)
                .WithMany(qd => qd.Question_Dimensions)
                .HasForeignKey(qi => qi.Dimension_Id);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<Quiz_Type> Quiz_Types { get; set; }

        public DbSet<Quiz_Level> Quiz_Levels { get; set; }

        public DbSet<User> Users { get; set; }

        //public DbSet<Role> Roles { get; set; }

        public DbSet<User_Quiz> User_Quizzes { get; set; }

        //public DbSet<User_Role> User_Roles { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        //public DbSet<Persistent_Login> Persistent_Logins { get; set; }

        public DbSet<User_Course> User_Courses { get; set; }

        public DbSet<Price_Package> Price_Packages { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Slide> Slides { get; set; }

        public DbSet<Question_Bank> Question_Banks { get; set; }

        public DbSet<Quiz_Question> Quiz_Questions { get; set; }

        public DbSet<Course_Package> Course_Packages { get; set; }

        public DbSet<Dimension> Dimensions { get; set; }

        public DbSet<Dimension_Type> Dimension_Types { get; set; }

        public DbSet<Course_Dimension> Course_Dimensions { get; set; }

        public DbSet<Question_Dimension> Question_Dimensions { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<User_Question_Answer> User_Question_Answers { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
