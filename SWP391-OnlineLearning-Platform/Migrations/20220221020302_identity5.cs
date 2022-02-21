using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class identity5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Statuss_Status_Id",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Statuss_Status_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Statuss_Status_Id",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_Packages_Statuss_Status_Id",
                table: "Price_Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Banks_Statuss_Status_Id",
                table: "Question_Banks");

            migrationBuilder.DropForeignKey(
                name: "FK_Slides_Statuss_Status_Id",
                table: "Slides");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Statuss_Status_Id",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss");

            migrationBuilder.RenameTable(
                name: "Statuss",
                newName: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Status_Status_Id",
                table: "Blogs",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Status_Status_Id",
                table: "Courses",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Status_Status_Id",
                table: "Lessons",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Price_Packages_Status_Status_Id",
                table: "Price_Packages",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Banks_Status_Status_Id",
                table: "Question_Banks",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slides_Status_Status_Id",
                table: "Slides",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Status_Status_Id",
                table: "User",
                column: "Status_Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Status_Status_Id",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Status_Status_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Status_Status_Id",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Price_Packages_Status_Status_Id",
                table: "Price_Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Banks_Status_Status_Id",
                table: "Question_Banks");

            migrationBuilder.DropForeignKey(
                name: "FK_Slides_Status_Status_Id",
                table: "Slides");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Status_Status_Id",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Statuss_Status_Id",
                table: "Blogs",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Statuss_Status_Id",
                table: "Courses",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Statuss_Status_Id",
                table: "Lessons",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Price_Packages_Statuss_Status_Id",
                table: "Price_Packages",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Banks_Statuss_Status_Id",
                table: "Question_Banks",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slides_Statuss_Status_Id",
                table: "Slides",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Statuss_Status_Id",
                table: "User",
                column: "Status_Id",
                principalTable: "Statuss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
