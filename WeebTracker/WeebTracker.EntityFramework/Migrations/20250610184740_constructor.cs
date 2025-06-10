using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeebTracker.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class constructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Startchapter",
                table: "EditionInfos",
                newName: "StartChapter");

            migrationBuilder.RenameColumn(
                name: "Endchapter",
                table: "EditionInfos",
                newName: "EndChapter");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartChapter",
                table: "EditionInfos",
                newName: "Startchapter");

            migrationBuilder.RenameColumn(
                name: "EndChapter",
                table: "EditionInfos",
                newName: "Endchapter");
        }
    }
}
