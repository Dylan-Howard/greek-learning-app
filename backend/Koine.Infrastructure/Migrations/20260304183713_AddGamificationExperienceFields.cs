using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koine.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGamificationExperienceFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalExperience",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceAwarded",
                table: "StudySessions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalExperience",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExperienceAwarded",
                table: "StudySessions");
        }
    }
}
