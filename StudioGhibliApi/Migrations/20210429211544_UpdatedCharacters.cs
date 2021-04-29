using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioGhibliApi.Migrations
{
    public partial class UpdatedCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmName",
                table: "Character");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilmName",
                table: "Character",
                type: "TEXT",
                nullable: true);
        }
    }
}
