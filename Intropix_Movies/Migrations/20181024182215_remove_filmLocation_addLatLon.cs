using Microsoft.EntityFrameworkCore.Migrations;

namespace Intropix_Movies.Migrations
{
    public partial class remove_filmLocation_addLatLon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filming_location",
                table: "Trailers");

            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "Trailers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Lon",
                table: "Trailers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "Trailers");

            migrationBuilder.AddColumn<string>(
                name: "filming_location",
                table: "Trailers",
                nullable: true);
        }
    }
}
