using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class UpdateQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1",
                table: "Question_Banks");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "Question_Banks");

            migrationBuilder.DropColumn(
                name: "Option3",
                table: "Question_Banks");

            migrationBuilder.DropColumn(
                name: "Option4",
                table: "Question_Banks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "Question_Banks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "Question_Banks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option3",
                table: "Question_Banks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Option4",
                table: "Question_Banks",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
