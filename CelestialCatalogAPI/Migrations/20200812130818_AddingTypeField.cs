using Microsoft.EntityFrameworkCore.Migrations;

namespace CelestialCatalogAPI.Migrations
{
    public partial class AddingTypeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "CelestialObjects",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "CelestialObjects");
        }
    }
}
