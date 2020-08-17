using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CelestialCatalogAPI.Migrations
{
    public partial class initalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CelestialObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Mass = table.Column<double>(nullable: false),
                    EquatorialDiameter = table.Column<double>(nullable: false),
                    SurfaceTemperature = table.Column<int>(nullable: false),
                    DiscoveryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelestialObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscoverySources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    EstablishmentDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    StateOwner = table.Column<string>(nullable: true),
                    CelestialObjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscoverySources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscoverySources_CelestialObjects_CelestialObjectId",
                        column: x => x.CelestialObjectId,
                        principalTable: "CelestialObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscoverySources_CelestialObjectId",
                table: "DiscoverySources",
                column: "CelestialObjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscoverySources");

            migrationBuilder.DropTable(
                name: "CelestialObjects");
        }
    }
}
