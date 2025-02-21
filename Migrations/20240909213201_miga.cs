using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ray2.Migrations
{
    /// <inheritdoc />
    public partial class miga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Track_URL",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Track_URL",
                table: "Tracks");
        }
    }
}
