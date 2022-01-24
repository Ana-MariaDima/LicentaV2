using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class SomeModif2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categorie_ingredient",
                table: "Ingredient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Categorie_ingredient",
                table: "Ingredient",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
