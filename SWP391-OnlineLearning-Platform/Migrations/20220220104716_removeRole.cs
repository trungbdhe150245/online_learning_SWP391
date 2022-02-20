using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP391_OnlineLearning_Platform.Migrations
{
    public partial class removeRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persistent_Logins");

            migrationBuilder.DropTable(
                name: "User_Roles");

            migrationBuilder.DropTable(
                name: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persistent_Logins",
                columns: table => new
                {
                    Series = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Used = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persistent_Logins", x => x.Series);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Roles", x => new { x.Role_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_User_Roles_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Roles_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Roles_User_Id",
                table: "User_Roles",
                column: "User_Id");
        }
    }
}
