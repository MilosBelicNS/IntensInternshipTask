using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_Platform_Intens.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateSkills",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateSkills", x => new { x.CandidateId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BirthDate", "ContractNumber", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "marko@mail.com", "Marko Petrovic" },
                    { 2, new DateTime(1997, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "pera@mail.com", "Petar Nikolic" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 22, "Russian" },
                    { 21, "English" },
                    { 20, "XML" },
                    { 19, "JSON" },
                    { 18, "Xamarin" },
                    { 17, "QA" },
                    { 16, "MongoDb" },
                    { 15, "Django" },
                    { 14, "Git" },
                    { 13, "SQL" },
                    { 12, "OOP" },
                    { 11, "AWS" },
                    { 10, "Azure" },
                    { 9, "Angular" },
                    { 8, "React" },
                    { 7, "PHP" },
                    { 6, "CSS" },
                    { 5, "HTML" },
                    { 4, "Javascript" },
                    { 3, "Python" },
                    { 2, "C#" },
                    { 1, "Java" },
                    { 23, "German" },
                    { 24, "French" }
                });

            migrationBuilder.InsertData(
                table: "CandidateSkills",
                columns: new[] { "CandidateId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 20 },
                    { 2, 19 },
                    { 1, 19 },
                    { 1, 17 },
                    { 2, 13 },
                    { 1, 13 },
                    { 2, 12 },
                    { 1, 12 },
                    { 2, 10 },
                    { 1, 10 },
                    { 2, 9 },
                    { 1, 8 },
                    { 2, 6 },
                    { 1, 6 },
                    { 2, 5 },
                    { 1, 5 },
                    { 2, 4 },
                    { 1, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 1, 2 },
                    { 1, 21 },
                    { 2, 21 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkills_SkillId",
                table: "CandidateSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateSkills");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
