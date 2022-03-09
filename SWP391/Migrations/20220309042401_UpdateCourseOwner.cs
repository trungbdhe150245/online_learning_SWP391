using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SWP391.Migrations
{
    public partial class UpdateCourseOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDimensions");

            migrationBuilder.DropTable(
                name: "QuestionDimensions");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "DimensionTypes");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseTime",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseTime",
                table: "Owners");

            migrationBuilder.CreateTable(
                name: "DimensionTypes",
                columns: table => new
                {
                    DimensionTypeId = table.Column<string>(type: "varchar(10)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionTypes", x => x.DimensionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    DimensionId = table.Column<string>(type: "varchar(10)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DimensionTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.DimensionId);
                    table.ForeignKey(
                        name: "FK_Dimensions_DimensionTypes_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "DimensionTypes",
                        principalColumn: "DimensionTypeId");
                });

            migrationBuilder.CreateTable(
                name: "CourseDimensions",
                columns: table => new
                {
                    CouresId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DimensionId = table.Column<string>(type: "varchar(10)", nullable: false),
                    CourseId = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDimensions", x => new { x.CouresId, x.DimensionId });
                    table.ForeignKey(
                        name: "FK_CourseDimensions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_CourseDimensions_Dimensions_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "Dimensions",
                        principalColumn: "DimensionId");
                });

            migrationBuilder.CreateTable(
                name: "QuestionDimensions",
                columns: table => new
                {
                    QuestionId = table.Column<string>(type: "varchar(10)", nullable: false),
                    DimensionId = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionDimensions", x => new { x.QuestionId, x.DimensionId });
                    table.ForeignKey(
                        name: "FK_QuestionDimensions_Dimensions_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "Dimensions",
                        principalColumn: "DimensionId");
                    table.ForeignKey(
                        name: "FK_QuestionDimensions_QuestionBanks_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionBanks",
                        principalColumn: "QuestionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDimensions_CourseId",
                table: "CourseDimensions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDimensions_DimensionId",
                table: "CourseDimensions",
                column: "DimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionDimensions_DimensionId",
                table: "QuestionDimensions",
                column: "DimensionId");
        }
    }
}
