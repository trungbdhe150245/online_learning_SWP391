using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class ChangeOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseOwners_Users_UserId",
                table: "CourseOwners");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CourseOwners",
                newName: "CourseOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseOwners_Users_CourseOwnerId",
                table: "CourseOwners",
                column: "CourseOwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseOwners_Users_CourseOwnerId",
                table: "CourseOwners");

            migrationBuilder.RenameColumn(
                name: "CourseOwnerId",
                table: "CourseOwners",
                newName: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseOwners_Users_UserId",
                table: "CourseOwners",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
