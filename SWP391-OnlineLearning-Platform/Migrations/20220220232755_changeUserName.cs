using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class changeUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_User_Id",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_User_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_User_Id",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Courses_Users_User_Id",
                table: "User_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Quizzes_Users_User_Id",
                table: "User_Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Statuss_Status_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_User_Quizzes_User_Id",
                table: "User_Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_User_Courses_User_Id",
                table: "User_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Comments_User_Id",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_User_Id",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Status_Id",
                table: "User",
                newName: "IX_User_Status_Id");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User_Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User_Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Quizzes_UserId",
                table: "User_Quizzes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Courses_UserId",
                table: "User_Courses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_User_UserId",
                table: "Blogs",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_User_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_User_User_Id",
                table: "Owners",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Statuss_Status_Id",
                table: "User",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Courses_User_UserId",
                table: "User_Courses",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Quizzes_User_UserId",
                table: "User_Quizzes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_User_UserId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_User_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_User_User_Id",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Statuss_Status_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Courses_User_UserId",
                table: "User_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Quizzes_User_UserId",
                table: "User_Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_User_Quizzes_UserId",
                table: "User_Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_User_Courses_UserId",
                table: "User_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User_Quizzes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User_Courses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_Status_Id",
                table: "Users",
                newName: "IX_Users_Status_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Quizzes_User_Id",
                table: "User_Quizzes",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Courses_User_Id",
                table: "User_Courses",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_Id",
                table: "Comments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_User_Id",
                table: "Blogs",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_User_Id",
                table: "Blogs",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_User_Id",
                table: "Comments",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_User_Id",
                table: "Owners",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Courses_Users_User_Id",
                table: "User_Courses",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Quizzes_Users_User_Id",
                table: "User_Quizzes",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Statuss_Status_Id",
                table: "Users",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
