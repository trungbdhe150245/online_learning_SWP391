using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class UpdatePricing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Price_Packages");

            migrationBuilder.DropColumn(
                name: "Sale_Price",
                table: "Price_Packages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Price_Packages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Sale_Price",
                table: "Price_Packages",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
