using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class Addalls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persistent_Logins",
                columns: table => new
                {
                    Series = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Token = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Used = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persistent_Logins", x => x.Series);
                });

            migrationBuilder.CreateTable(
                name: "Quiz_Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quiz_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Featured = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Short_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail_URL = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Price_Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    List_price = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sale_Price = table.Column<float>(type: "real", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Price_Packages_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Auth_Provider = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Avatar_Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reset_password_token = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Verification_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Number_question = table.Column<int>(type: "int", nullable: false),
                    Pass_rate = table.Column<float>(type: "real", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Quiz_Level_Id = table.Column<int>(type: "int", nullable: false),
                    Quiz_Type_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Quizzes_Quiz_Levels_Quiz_Level_Id",
                        column: x => x.Quiz_Level_Id,
                        principalTable: "Quiz_Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Quizzes_Quiz_Types_Quiz_Type_Id",
                        column: x => x.Quiz_Type_Id,
                        principalTable: "Quiz_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Topic_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic_Order = table.Column<int>(type: "int", nullable: false),
                    Topic_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Topic_Id);
                    table.ForeignKey(
                        name: "FK_Topics_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Featured = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Blogs_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => new { x.User_Id, x.Course_Id });
                    table.ForeignKey(
                        name: "FK_Owners_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Owners_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User_Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Registration_Status = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Price_Package_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Courses_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Courses_Price_Packages_Price_Package_Id",
                        column: x => x.Price_Package_Id,
                        principalTable: "Price_Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Courses_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User_Roles",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Roles", x => new { x.Role_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_User_Roles_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Roles_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User_Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<float>(type: "real", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quiz_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Quizzes_Quizzes_Quiz_Id",
                        column: x => x.Quiz_Id,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Quizzes_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Category_Id",
                table: "Blogs",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Status_Id",
                table: "Blogs",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_User_Id",
                table: "Blogs",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Category_Id",
                table: "Courses",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Status_Id",
                table: "Courses",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_Course_Id",
                table: "Owners",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Price_Packages_Status_Id",
                table: "Price_Packages",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_Course_Id",
                table: "Quizzes",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_Quiz_Level_Id",
                table: "Quizzes",
                column: "Quiz_Level_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_Quiz_Type_Id",
                table: "Quizzes",
                column: "Quiz_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Course_Id",
                table: "Topics",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Courses_Course_Id",
                table: "User_Courses",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Courses_Price_Package_Id",
                table: "User_Courses",
                column: "Price_Package_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Courses_User_Id",
                table: "User_Courses",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Quizzes_Quiz_Id",
                table: "User_Quizzes",
                column: "Quiz_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Quizzes_User_Id",
                table: "User_Quizzes",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Roles_User_Id",
                table: "User_Roles",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Status_Id",
                table: "Users",
                column: "Status_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Persistent_Logins");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "User_Courses");

            migrationBuilder.DropTable(
                name: "User_Quizzes");

            migrationBuilder.DropTable(
                name: "User_Roles");

            migrationBuilder.DropTable(
                name: "Price_Packages");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Quiz_Levels");

            migrationBuilder.DropTable(
                name: "Quiz_Types");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Statuss");
        }
    }
}
