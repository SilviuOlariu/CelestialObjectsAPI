using Microsoft.EntityFrameworkCore.Migrations;

namespace CelestialCatalogAPI.Migrations
{
    public partial class addingDiscoverySourceIdField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscoverySourceId",
                table: "CelestialObjects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscoverySourceId",
                table: "CelestialObjects");
        }
    }
}
