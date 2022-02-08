using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class AddedLast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course_Packages",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Package_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Packages", x => new { x.Course_Id, x.Package_Id });
                    table.ForeignKey(
                        name: "FK_Course_Packages_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Course_Packages_Price_Packages_Package_Id",
                        column: x => x.Package_Id,
                        principalTable: "Price_Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Dimension_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimension_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Lesson_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Html_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lesson_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lesson_Order = table.Column<int>(type: "int", nullable: false),
                    Video_Link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false),
                    Topic_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Lesson_Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Lessons_Topics_Topic_Id",
                        column: x => x.Topic_Id,
                        principalTable: "Topics",
                        principalColumn: "Topic_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Question_Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Option1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Level_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Banks_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Question_Banks_Quiz_Levels_Level_Id",
                        column: x => x.Level_Id,
                        principalTable: "Quiz_Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Question_Banks_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image_Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slides_Statuss_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "Statuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_Dimension_Types_Type_Id",
                        column: x => x.Type_Id,
                        principalTable: "Dimension_Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz_Questions",
                columns: table => new
                {
                    Quiz_Id = table.Column<int>(type: "int", nullable: false),
                    Question_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz_Questions", x => new { x.Quiz_Id, x.Question_Id });
                    table.ForeignKey(
                        name: "FK_Quiz_Questions_Question_Banks_Question_Id",
                        column: x => x.Question_Id,
                        principalTable: "Question_Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Quiz_Questions_Quizzes_Quiz_Id",
                        column: x => x.Quiz_Id,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "User_Question_Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Choice = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Question_Id = table.Column<int>(type: "int", nullable: false),
                    User_Quiz_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Question_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Question_Answers_Question_Banks_Question_Id",
                        column: x => x.Question_Id,
                        principalTable: "Question_Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_User_Question_Answers_User_Quizzes_User_Quiz_Id",
                        column: x => x.User_Quiz_Id,
                        principalTable: "User_Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Course_Dimensions",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Dimension_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Dimensions", x => new { x.Course_Id, x.Dimension_Id });
                    table.ForeignKey(
                        name: "FK_Course_Dimensions_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Course_Dimensions_Dimensions_Dimension_Id",
                        column: x => x.Dimension_Id,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Question_Dimensions",
                columns: table => new
                {
                    Question_Id = table.Column<int>(type: "int", nullable: false),
                    Dimension_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question_Dimensions", x => new { x.Question_Id, x.Dimension_Id });
                    table.ForeignKey(
                        name: "FK_Question_Dimensions_Dimensions_Dimension_Id",
                        column: x => x.Dimension_Id,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Question_Dimensions_Question_Banks_Question_Id",
                        column: x => x.Question_Id,
                        principalTable: "Question_Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Dimensions_Dimension_Id",
                table: "Course_Dimensions",
                column: "Dimension_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Packages_Package_Id",
                table: "Course_Packages",
                column: "Package_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_Type_Id",
                table: "Dimensions",
                column: "Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_Status_Id",
                table: "Lessons",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_Topic_Id",
                table: "Lessons",
                column: "Topic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Banks_Course_Id",
                table: "Question_Banks",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Banks_Level_Id",
                table: "Question_Banks",
                column: "Level_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Banks_Status_Id",
                table: "Question_Banks",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Dimensions_Dimension_Id",
                table: "Question_Dimensions",
                column: "Dimension_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_Questions_Question_Id",
                table: "Quiz_Questions",
                column: "Question_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_Status_Id",
                table: "Slides",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Question_Answers_Question_Id",
                table: "User_Question_Answers",
                column: "Question_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Question_Answers_User_Quiz_Id",
                table: "User_Question_Answers",
                column: "User_Quiz_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Dimensions");

            migrationBuilder.DropTable(
                name: "Course_Packages");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Question_Dimensions");

            migrationBuilder.DropTable(
                name: "Quiz_Questions");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "User_Question_Answers");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Question_Banks");

            migrationBuilder.DropTable(
                name: "Dimension_Types");
        }
    }
}
