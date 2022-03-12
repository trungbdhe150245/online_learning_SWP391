﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWP391.Data;

namespace SWP391.Migrations
{
    [DbContext(typeof(LearningDbContext))]
    [Migration("20220312023059_ChangekeysType1")]
    partial class ChangekeysType1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("SWP391.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Subcription")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SWP391.Models.Attempt", b =>
                {
                    b.Property<string>("AttemptId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QuizId")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalMark")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AttemptId");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("Attempts");
                });

            modelBuilder.Entity("SWP391.Models.AttemptDetailed", b =>
                {
                    b.Property<string>("AttemptId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QuestionBankId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UserAnswer")
                        .HasColumnType("text");

                    b.HasKey("AttemptId", "QuestionBankId");

                    b.HasIndex("QuestionBankId");

                    b.ToTable("AttemptDetaileds");
                });

            modelBuilder.Entity("SWP391.Models.Blog", b =>
                {
                    b.Property<string>("BlogId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Brief")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SlideId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailURL")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SlideId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("SWP391.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryValue")
                        .HasColumnType("varchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SWP391.Models.Comment", b =>
                {
                    b.Property<string>("CommentId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("BlogId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CommentBody")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SWP391.Models.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("SlideId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailURL")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SlideId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SWP391.Models.CourseOwner", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("PurchaseTime")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseOwners");
                });

            modelBuilder.Entity("SWP391.Models.Lesson", b =>
                {
                    b.Property<string>("LessonId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LessonName")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("LessonOrder")
                        .HasColumnType("int");

                    b.Property<string>("Script")
                        .HasColumnType("text");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.Property<string>("VideoURL")
                        .HasColumnType("text");

                    b.HasKey("LessonId");

                    b.HasIndex("TopicId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("SWP391.Models.PricePackage", b =>
                {
                    b.Property<string>("PricePackageId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("PricePackageId");

                    b.HasIndex("StatusId");

                    b.ToTable("PricePackages");
                });

            modelBuilder.Entity("SWP391.Models.QuestionBank", b =>
                {
                    b.Property<string>("QuestionId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Explanation")
                        .HasColumnType("text");

                    b.Property<string>("OptionA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizLevelId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("QuestionId");

                    b.HasIndex("CourseId");

                    b.HasIndex("QuizLevelId");

                    b.HasIndex("StatusId");

                    b.ToTable("QuestionBanks");
                });

            modelBuilder.Entity("SWP391.Models.Quiz", b =>
                {
                    b.Property<string>("QuizId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("QuestionNum")
                        .HasColumnType("int");

                    b.Property<int>("QuizLevelId")
                        .HasColumnType("int");

                    b.Property<int>("QuizTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("QuizId");

                    b.HasIndex("CourseId");

                    b.HasIndex("QuizLevelId");

                    b.HasIndex("QuizTypeId");

                    b.HasIndex("TopicId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("SWP391.Models.QuizLevel", b =>
                {
                    b.Property<int>("QuizLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuizLevelName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("QuizLevelId");

                    b.ToTable("QuizLevels");
                });

            modelBuilder.Entity("SWP391.Models.QuizQuestion", b =>
                {
                    b.Property<string>("QuizId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QuestionId")
                        .HasColumnType("varchar(10)");

                    b.HasKey("QuizId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("SWP391.Models.QuizType", b =>
                {
                    b.Property<int>("QuizTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuizTypeName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("QuizTypeId");

                    b.ToTable("QuizTypes");
                });

            modelBuilder.Entity("SWP391.Models.Slide", b =>
                {
                    b.Property<int>("SlideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SlideValue")
                        .HasColumnType("varchar(255)");

                    b.HasKey("SlideId");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("SWP391.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusValue")
                        .HasColumnType("varchar(255)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("SWP391.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TopicName")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TopicOrder")
                        .HasColumnType("int");

                    b.HasKey("TopicId");

                    b.HasIndex("CourseId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SWP391.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SWP391.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWP391.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SWP391.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SWP391.Models.Attempt", b =>
                {
                    b.HasOne("SWP391.Models.Quiz", "Quiz")
                        .WithMany("Attempts")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("SWP391.Models.AppUser", "User")
                        .WithMany("Attempts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391.Models.AttemptDetailed", b =>
                {
                    b.HasOne("SWP391.Models.Attempt", "Attempt")
                        .WithMany("AttemptDetaileds")
                        .HasForeignKey("AttemptId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.QuestionBank", "QuestionBank")
                        .WithMany("AttemptDetaileds")
                        .HasForeignKey("QuestionBankId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Attempt");

                    b.Navigation("QuestionBank");
                });

            modelBuilder.Entity("SWP391.Models.Blog", b =>
                {
                    b.HasOne("SWP391.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Slide", "Slide")
                        .WithMany("Blogs")
                        .HasForeignKey("SlideId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Status", "Status")
                        .WithMany("Blogs")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.AppUser", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Category");

                    b.Navigation("Slide");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391.Models.Comment", b =>
                {
                    b.HasOne("SWP391.Models.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("SWP391.Models.AppUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Blog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391.Models.Course", b =>
                {
                    b.HasOne("SWP391.Models.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Slide", "Slide")
                        .WithMany("Courses")
                        .HasForeignKey("SlideId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Status", "Status")
                        .WithMany("Courses")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.AppUser", "User")
                        .WithMany("Courses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Category");

                    b.Navigation("Slide");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391.Models.CourseOwner", b =>
                {
                    b.HasOne("SWP391.Models.Course", "Course")
                        .WithMany("CourseOwners")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.AppUser", "User")
                        .WithMany("CourseOwners")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391.Models.Lesson", b =>
                {
                    b.HasOne("SWP391.Models.Topic", "Topic")
                        .WithMany("Lessons")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("SWP391.Models.PricePackage", b =>
                {
                    b.HasOne("SWP391.Models.Status", "Status")
                        .WithMany("PricePackages")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SWP391.Models.QuestionBank", b =>
                {
                    b.HasOne("SWP391.Models.Course", "Course")
                        .WithMany("QuestionBanks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("SWP391.Models.QuizLevel", "QuizLevel")
                        .WithMany("QuestionBanks")
                        .HasForeignKey("QuizLevelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Status", "Status")
                        .WithMany("QuestionBanks")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("QuizLevel");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SWP391.Models.Quiz", b =>
                {
                    b.HasOne("SWP391.Models.Course", null)
                        .WithMany("Quizzes")
                        .HasForeignKey("CourseId");

                    b.HasOne("SWP391.Models.QuizLevel", "QuizLevel")
                        .WithMany("Quizzes")
                        .HasForeignKey("QuizLevelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.QuizType", "QuizType")
                        .WithMany("Quizzes")
                        .HasForeignKey("QuizTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Topic", "Topic")
                        .WithMany("Quizzes")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("QuizLevel");

                    b.Navigation("QuizType");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("SWP391.Models.QuizQuestion", b =>
                {
                    b.HasOne("SWP391.Models.QuestionBank", "QuestionBank")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SWP391.Models.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("QuestionBank");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("SWP391.Models.Topic", b =>
                {
                    b.HasOne("SWP391.Models.Course", "Course")
                        .WithMany("Topics")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Course");
                });

            modelBuilder.Entity("SWP391.Models.AppUser", b =>
                {
                    b.Navigation("Attempts");

                    b.Navigation("Blogs");

                    b.Navigation("Comments");

                    b.Navigation("CourseOwners");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SWP391.Models.Attempt", b =>
                {
                    b.Navigation("AttemptDetaileds");
                });

            modelBuilder.Entity("SWP391.Models.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SWP391.Models.Category", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SWP391.Models.Course", b =>
                {
                    b.Navigation("CourseOwners");

                    b.Navigation("QuestionBanks");

                    b.Navigation("Quizzes");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("SWP391.Models.QuestionBank", b =>
                {
                    b.Navigation("AttemptDetaileds");

                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("SWP391.Models.Quiz", b =>
                {
                    b.Navigation("Attempts");

                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("SWP391.Models.QuizLevel", b =>
                {
                    b.Navigation("QuestionBanks");

                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("SWP391.Models.QuizType", b =>
                {
                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("SWP391.Models.Slide", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SWP391.Models.Status", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Courses");

                    b.Navigation("PricePackages");

                    b.Navigation("QuestionBanks");
                });

            modelBuilder.Entity("SWP391.Models.Topic", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
