using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    classroom = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    ability = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_courseid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstexamn = table.Column<double>(type: "float", nullable: false),
                    secondpartExam = table.Column<double>(type: "float", nullable: false),
                    firstpratice = table.Column<double>(type: "float", nullable: false),
                    secondpratice = table.Column<double>(type: "float", nullable: false),
                    final = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_qualificationid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    lastname = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR(200)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    yeard = table.Column<int>(type: "INT", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    udated_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_studentid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    name = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    credits = table.Column<int>(type: "int", nullable: false),
                    IdCourse = table.Column<int>(type: "INT", nullable: false),
                    IdQualification = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sujectid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Course_IdCourse",
                        column: x => x.IdCourse,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_Qualification_IdQualification",
                        column: x => x.IdQualification,
                        principalTable: "Qualification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentToSubject",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "INT", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentToSubject", x => new { x.IdStudent, x.IdSubject });
                    table.ForeignKey(
                        name: "FK_StudentToSubject_Student_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentToSubject_Subject_IdSubject",
                        column: x => x.IdSubject,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentToSubject_IdSubject",
                table: "StudentToSubject",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_IdCourse",
                table: "Subject",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_IdQualification",
                table: "Subject",
                column: "IdQualification");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentToSubject");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Qualification");
        }
    }
}
