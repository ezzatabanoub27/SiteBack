using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ray2.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cover_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    artistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_artistId",
                        column: x => x.artistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    PlayListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.PlayListId);
                    table.ForeignKey(
                        name: "FK_PlayLists_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Trendy = table.Column<bool>(type: "bit", nullable: false),
                    Romantic = table.Column<bool>(type: "bit", nullable: true),
                    Rab = table.Column<bool>(type: "bit", nullable: true),
                    Happy = table.Column<bool>(type: "bit", nullable: true),
                    Sad = table.Column<bool>(type: "bit", nullable: true),
                    Relaxing = table.Column<bool>(type: "bit", nullable: true),
                    Mahraganat = table.Column<bool>(type: "bit", nullable: true),
                    albumId = table.Column<int>(type: "int", nullable: false),
                    artistiD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_albumId",
                        column: x => x.albumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tracks_Artists_artistiD",
                        column: x => x.artistiD,
                        principalTable: "Artists",
                        principalColumn: "ArtistId");
                });

            migrationBuilder.CreateTable(
                name: "playListT_Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playlistId = table.Column<int>(type: "int", nullable: false),
                    trackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playListT_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_playListT_Tracks_PlayLists_playlistId",
                        column: x => x.playlistId,
                        principalTable: "PlayLists",
                        principalColumn: "PlayListId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_playListT_Tracks_Tracks_trackId",
                        column: x => x.trackId,
                        principalTable: "Tracks",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_artistId",
                table: "Albums",
                column: "artistId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_userid",
                table: "Favorites",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_userid",
                table: "PlayLists",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_playListT_Tracks_playlistId",
                table: "playListT_Tracks",
                column: "playlistId");

            migrationBuilder.CreateIndex(
                name: "IX_playListT_Tracks_trackId",
                table: "playListT_Tracks",
                column: "trackId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_albumId",
                table: "Tracks",
                column: "albumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_artistiD",
                table: "Tracks",
                column: "artistiD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "playListT_Tracks");

            migrationBuilder.DropTable(
                name: "PlayLists");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
