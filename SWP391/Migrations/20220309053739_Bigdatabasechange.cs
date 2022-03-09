using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class Bigdatabasechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Featured_FeaturedId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Featured_FeaturedId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Slides_Status_StatusId",
                table: "Slides");

            migrationBuilder.DropTable(
                name: "Featured");

            migrationBuilder.DropIndex(
                name: "IX_Slides_StatusId",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CourseURL",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "ThumbnailURL",
                table: "Slides");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Slides",
                newName: "SlideValue");

            migrationBuilder.RenameColumn(
                name: "FeaturedId",
                table: "Blogs",
                newName: "SlideId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_FeaturedId",
                table: "Blogs",
                newName: "IX_Blogs_SlideId");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserId",
                table: "Courses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Slides_SlideId",
                table: "Blogs",
                column: "SlideId",
                principalTable: "Slides",
                principalColumn: "SlideId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Slides_FeaturedId",
                table: "Courses",
                column: "FeaturedId",
                principalTable: "Slides",
                principalColumn: "SlideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_UserId",
                table: "Courses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Slides_SlideId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Slides_FeaturedId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_UserId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_UserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "SlideValue",
                table: "Slides",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "SlideId",
                table: "Blogs",
                newName: "FeaturedId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_SlideId",
                table: "Blogs",
                newName: "IX_Blogs_FeaturedId");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseURL",
                table: "Slides",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Slides",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Slides",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailURL",
                table: "Slides",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Featured",
                columns: table => new
                {
                    FeaturedId = table.Column<string>(type: "varchar(10)", nullable: false),
                    Value = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Featured", x => x.FeaturedId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slides_StatusId",
                table: "Slides",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Featured_FeaturedId",
                table: "Blogs",
                column: "FeaturedId",
                principalTable: "Featured",
                principalColumn: "FeaturedId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Featured_FeaturedId",
                table: "Courses",
                column: "FeaturedId",
                principalTable: "Featured",
                principalColumn: "FeaturedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Slides_Status_StatusId",
                table: "Slides",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId");
        }
    }
}
