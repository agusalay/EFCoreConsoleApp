using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreConsoleApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "EndDate", "StartDate" },
                values: new object[] { 1, "CourseName 1", new DateTime(2021, 1, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1038), new DateTime(2020, 12, 19, 15, 24, 56, 130, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "EndDate", "StartDate" },
                values: new object[] { 2, "CourseName 2", new DateTime(2021, 1, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1675), new DateTime(2020, 12, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "EndDate", "StartDate" },
                values: new object[] { 3, "CourseName 3", new DateTime(2021, 1, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1690), new DateTime(2020, 12, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "EndDate", "StartDate" },
                values: new object[] { 4, "CourseName 4", new DateTime(2021, 1, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1693), new DateTime(2020, 12, 19, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName", "EndDate", "StartDate" },
                values: new object[] { 5, "CourseName 5", new DateTime(2021, 1, 18, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1695), new DateTime(2020, 12, 19, 15, 24, 56, 132, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "Name" },
                values: new object[] { 1, 1, "Abhimanyu K Vatsa" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "Name" },
                values: new object[] { 2, 1, "Deepak Kumar Gupta" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "Name" },
                values: new object[] { 3, 2, "Manish Kumar" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "Name" },
                values: new object[] { 4, 3, "Rohit Ranjan" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "Name" },
                values: new object[] { 5, 4, "Shivam" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
