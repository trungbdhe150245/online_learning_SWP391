using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class AddSubcription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Subcription",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subcription",
                table: "Users");
        }
    }
}
