using Microsoft.EntityFrameworkCore.Migrations;

namespace CelestialCatalogAPI.Migrations
{
    public partial class addingOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CelestialObjects_DiscoverySourceId",
                table: "CelestialObjects",
                column: "DiscoverySourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CelestialObjects_DiscoverySources_DiscoverySourceId",
                table: "CelestialObjects",
                column: "DiscoverySourceId",
                principalTable: "DiscoverySources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CelestialObjects_DiscoverySources_DiscoverySourceId",
                table: "CelestialObjects");

            migrationBuilder.DropIndex(
                name: "IX_CelestialObjects_DiscoverySourceId",
                table: "CelestialObjects");
        }
    }
}
