using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Data
{
    public class OnlineLearningDbContext : DbContext
    {
        public OnlineLearningDbContext(DbContextOptions<OnlineLearningDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Role>().HasKey(ur => new { ur.Role_Id, ur.User_Id });

            modelBuilder.Entity<User_Role>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.User_Roles)
                .HasForeignKey(ui => ui.User_Id);

            modelBuilder.Entity<User_Role>()
                .HasOne(u => u.Role)
                .WithMany(ur => ur.User_Roles)
                .HasForeignKey(ui => ui.Role_Id);

            modelBuilder.Entity<Owner>().HasKey(uc => new { uc.User_Id, uc.Course_Id });

            modelBuilder.Entity<Owner>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.User_Id);

            modelBuilder.Entity<Owner>()
                .HasOne(u => u.Course)
                .WithMany(ur => ur.Owners)
                .HasForeignKey(ui => ui.Course_Id);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Status> Statuss { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<Quiz_Type> Quiz_Types { get; set; }

        public DbSet<Quiz_Level> Quiz_Levels { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User_Quiz> User_Quizzes { get; set; }

        public DbSet<User_Role> User_Roles { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Persistent_Login> Persistent_Logins { get; set; }

        public DbSet<User_Course> User_Courses { get; set; }

        public DbSet<Price_Package> Price_Packages { get; set; }

        public DbSet<Topic> Topics { get; set; }

    }
}
