using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class EditPricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Price_Packages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Price_Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
