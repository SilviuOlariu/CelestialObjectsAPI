using Microsoft.EntityFrameworkCore.Migrations;

namespace CelestialCatalogAPI.Migrations
{
    public partial class refactoringtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscoverySources_CelestialObjects_CelestialObjectId",
                table: "DiscoverySources");

            migrationBuilder.DropIndex(
                name: "IX_DiscoverySources_CelestialObjectId",
                table: "DiscoverySources");

            migrationBuilder.DropColumn(
                name: "CelestialObjectId",
                table: "DiscoverySources");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CelestialObjectId",
                table: "DiscoverySources",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DiscoverySources_CelestialObjectId",
                table: "DiscoverySources",
                column: "CelestialObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscoverySources_CelestialObjects_CelestialObjectId",
                table: "DiscoverySources",
                column: "CelestialObjectId",
                principalTable: "CelestialObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
