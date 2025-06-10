using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeebTracker.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collectibles",
                columns: table => new
                {
                    CollectiblesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_German = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_Japanese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finalised = table.Column<bool>(type: "bit", nullable: false),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectibles", x => x.CollectiblesID);
                });

            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    CollectiblesID = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.CollectiblesID);
                    table.ForeignKey(
                        name: "FK_Animes_Collectibles_CollectiblesID",
                        column: x => x.CollectiblesID,
                        principalTable: "Collectibles",
                        principalColumn: "CollectiblesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EditionInfos",
                columns: table => new
                {
                    EditionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectiblesID = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionInfos", x => x.EditionID);
                    table.ForeignKey(
                        name: "FK_EditionInfos_Collectibles_CollectiblesID",
                        column: x => x.CollectiblesID,
                        principalTable: "Collectibles",
                        principalColumn: "CollectiblesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manga",
                columns: table => new
                {
                    CollectiblesID = table.Column<int>(type: "int", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manga", x => x.CollectiblesID);
                    table.ForeignKey(
                        name: "FK_Manga_Collectibles_CollectiblesID",
                        column: x => x.CollectiblesID,
                        principalTable: "Collectibles",
                        principalColumn: "CollectiblesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeEditionInfos",
                columns: table => new
                {
                    EditionID = table.Column<int>(type: "int", nullable: false),
                    StorageMedium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Startepisode = table.Column<int>(type: "int", nullable: false),
                    Endepisode = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeEditionInfos", x => x.EditionID);
                    table.ForeignKey(
                        name: "FK_AnimeEditionInfos_EditionInfos_EditionID",
                        column: x => x.EditionID,
                        principalTable: "EditionInfos",
                        principalColumn: "EditionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MangaEditionInfos",
                columns: table => new
                {
                    EditionID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Startchapter = table.Column<int>(type: "int", nullable: false),
                    Endchapter = table.Column<int>(type: "int", nullable: false),
                    FirstEdition = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaEditionInfos", x => x.EditionID);
                    table.ForeignKey(
                        name: "FK_MangaEditionInfos_EditionInfos_EditionID",
                        column: x => x.EditionID,
                        principalTable: "EditionInfos",
                        principalColumn: "EditionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditionInfos_CollectiblesID",
                table: "EditionInfos",
                column: "CollectiblesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeEditionInfos");

            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "Manga");

            migrationBuilder.DropTable(
                name: "MangaEditionInfos");

            migrationBuilder.DropTable(
                name: "EditionInfos");

            migrationBuilder.DropTable(
                name: "Collectibles");
        }
    }
}
