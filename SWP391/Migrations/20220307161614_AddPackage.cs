using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class AddPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    PackageId = table.Column<string>(type: "varchar(10)", nullable: false),
                    PackageName = table.Column<string>(type: "varchar(255)", nullable: true),
                    PackageDescription = table.Column<string>(type: "varchar(max)", nullable: true),
                    PackagePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.PackageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package");
        }
    }
}
