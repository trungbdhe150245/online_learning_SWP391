using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class AddPackage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Package",
                table: "Package");

            migrationBuilder.RenameTable(
                name: "Package",
                newName: "Packages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Packages",
                table: "Packages",
                column: "PackageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Packages",
                table: "Packages");

            migrationBuilder.RenameTable(
                name: "Packages",
                newName: "Package");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Package",
                table: "Package",
                column: "PackageId");
        }
    }
}
