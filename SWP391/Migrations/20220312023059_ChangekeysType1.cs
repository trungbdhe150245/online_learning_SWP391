using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class ChangekeysType1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Topics_PricePackageId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_PricePackageId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "PricePackageId",
                table: "Lessons");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TopicId",
                table: "Lessons",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_TopicId",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "PricePackageId",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_PricePackageId",
                table: "Lessons",
                column: "PricePackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Topics_PricePackageId",
                table: "Lessons",
                column: "PricePackageId",
                principalTable: "Topics",
                principalColumn: "TopicId");
        }
    }
}
