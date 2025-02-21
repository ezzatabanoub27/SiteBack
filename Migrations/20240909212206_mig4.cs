using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ray2.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_albumId",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "albumId",
                table: "Tracks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_albumId",
                table: "Tracks",
                column: "albumId",
                principalTable: "Albums",
                principalColumn: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_albumId",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "albumId",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_albumId",
                table: "Tracks",
                column: "albumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
