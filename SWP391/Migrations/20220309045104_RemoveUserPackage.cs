using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391.Migrations
{
    public partial class RemoveUserPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Courses_CourseId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Users_UserId",
                table: "Owners");

            migrationBuilder.DropTable(
                name: "CoursePackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "CourseOwners");

            migrationBuilder.RenameIndex(
                name: "IX_Owners_CourseId",
                table: "CourseOwners",
                newName: "IX_CourseOwners_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseOwners",
                table: "CourseOwners",
                columns: new[] { "UserId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseOwners_Courses_CourseId",
                table: "CourseOwners",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseOwners_Users_UserId",
                table: "CourseOwners",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseOwners_Courses_CourseId",
                table: "CourseOwners");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseOwners_Users_UserId",
                table: "CourseOwners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseOwners",
                table: "CourseOwners");

            migrationBuilder.RenameTable(
                name: "CourseOwners",
                newName: "Owners");

            migrationBuilder.RenameIndex(
                name: "IX_CourseOwners_CourseId",
                table: "Owners",
                newName: "IX_Owners_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                columns: new[] { "UserId", "CourseId" });

            migrationBuilder.CreateTable(
                name: "CoursePackages",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "varchar(10)", nullable: false),
                    PricePackageId = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePackages", x => new { x.CourseId, x.PricePackageId });
                    table.ForeignKey(
                        name: "FK_CoursePackages_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_CoursePackages_PricePackages_PricePackageId",
                        column: x => x.PricePackageId,
                        principalTable: "PricePackages",
                        principalColumn: "PricePackageId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePackages_PricePackageId",
                table: "CoursePackages",
                column: "PricePackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Courses_CourseId",
                table: "Owners",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Users_UserId",
                table: "Owners",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
