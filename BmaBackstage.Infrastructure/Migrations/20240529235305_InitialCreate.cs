using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BmaBackstage.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    LastSafeSportTestDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastBackgroundCheckDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SpecialNeeds = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ContractType = table.Column<string>(type: "TEXT", nullable: false),
                    ContractStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Person_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Relationship = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    PersonId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContacts_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Progressions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentStageNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progressions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progressions_Person_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Progressions_Person_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TimeSheetEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Day = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheetEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSheetEntries_Person_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProgressionStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProgressionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressionStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressionStages_Progressions_ProgressionId",
                        column: x => x.ProgressionId,
                        principalTable: "Progressions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 34, nullable: false),
                    ProgressionStageId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PersonId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RequiredAge = table.Column<int>(type: "INTEGER", nullable: true),
                    RequiredLessonCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Passed = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requirement_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requirement_ProgressionStages_ProgressionStageId",
                        column: x => x.ProgressionStageId,
                        principalTable: "ProgressionStages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AttendanceRequirementId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Person_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Requirement_AttendanceRequirementId",
                        column: x => x.AttendanceRequirementId,
                        principalTable: "Requirement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_StudentId",
                table: "Contracts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContacts_PersonId",
                table: "EmergencyContacts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_AttendanceRequirementId",
                table: "Lessons",
                column: "AttendanceRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_InstructorId",
                table: "Lessons",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Progressions_InstructorId",
                table: "Progressions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Progressions_StudentId",
                table: "Progressions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressionStages_ProgressionId",
                table: "ProgressionStages",
                column: "ProgressionId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirement_PersonId",
                table: "Requirement",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirement_ProgressionStageId",
                table: "Requirement",
                column: "ProgressionStageId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheetEntries_InstructorId",
                table: "TimeSheetEntries",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "TimeSheetEntries");

            migrationBuilder.DropTable(
                name: "Requirement");

            migrationBuilder.DropTable(
                name: "ProgressionStages");

            migrationBuilder.DropTable(
                name: "Progressions");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
