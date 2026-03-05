using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koine.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStudyFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudySessions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfigJson = table.Column<string>(type: "nvarchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudySessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCardProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VocabularyId = table.Column<int>(type: "int", nullable: false),
                    Stability = table.Column<float>(type: "real", nullable: false),
                    Difficulty = table.Column<float>(type: "real", nullable: false),
                    ElapsedDays = table.Column<float>(type: "real", nullable: false),
                    ScheduledDays = table.Column<float>(type: "real", nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    Lapses = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    LastReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCardProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCardProgress_Vocabularies_VocabularyId",
                        column: x => x.VocabularyId,
                        principalTable: "Vocabularies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocabularyId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    GivenRating = table.Column<int>(type: "int", nullable: true),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mode = table.Column<int>(type: "int", nullable: false),
                    ChoicesJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionCards_StudySessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "StudySessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SessionCards_SessionId",
                table: "SessionCards",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardProgress_UserId_VocabularyId",
                table: "UserCardProgress",
                columns: new[] { "UserId", "VocabularyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCardProgress_VocabularyId",
                table: "UserCardProgress",
                column: "VocabularyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardProgress_Due",
                table: "UserCardProgress",
                columns: new[] { "UserId", "NextReviewDate" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionCards");

            migrationBuilder.DropTable(
                name: "UserCardProgress");

            migrationBuilder.DropTable(
                name: "StudySessions");
        }
    }
}
