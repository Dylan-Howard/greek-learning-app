using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koine.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClerkIdToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClerkId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClerkId",
                table: "Users",
                column: "ClerkId",
                unique: true,
                filter: "[ClerkId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_ClerkId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClerkId",
                table: "Users");
        }
    }
}
