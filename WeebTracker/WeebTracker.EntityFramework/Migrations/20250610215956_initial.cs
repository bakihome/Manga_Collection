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
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectiblesTempId11 = table.Column<int>(type: "int", nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectiblesTempId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectibles", x => x.CollectiblesID);
                    table.ForeignKey(
                        name: "FK_Collectibles_Collectibles_CollectiblesTempId11",
                        column: x => x.CollectiblesTempId11,
                        principalTable: "Collectibles",
                        principalColumn: "CollectiblesID");
                    table.ForeignKey(
                        name: "FK_Collectibles_Collectibles_CollectiblesTempId2",
                        column: x => x.CollectiblesTempId2,
                        principalTable: "Collectibles",
                        principalColumn: "CollectiblesID");
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    StorageMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Startepisode = table.Column<int>(type: "int", nullable: true),
                    Endepisode = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartChapter = table.Column<int>(type: "int", nullable: true),
                    EndChapter = table.Column<int>(type: "int", nullable: true),
                    FirstEdition = table.Column<bool>(type: "bit", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Collectibles_CollectiblesTempId11",
                table: "Collectibles",
                column: "CollectiblesTempId11");

            migrationBuilder.CreateIndex(
                name: "IX_Collectibles_CollectiblesTempId2",
                table: "Collectibles",
                column: "CollectiblesTempId2");

            migrationBuilder.CreateIndex(
                name: "IX_EditionInfos_CollectiblesID",
                table: "EditionInfos",
                column: "CollectiblesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionInfos");

            migrationBuilder.DropTable(
                name: "Collectibles");
        }
    }
}
