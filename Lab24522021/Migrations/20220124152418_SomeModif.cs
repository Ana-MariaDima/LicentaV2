using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class SomeModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descriere_IdCategorieIngredient",
                table: "CategorieIngredient",
                newName: "Descriere_categorie_ingredient");

            migrationBuilder.AddColumn<int>(
                name: "Categorie_ingredient",
                table: "Ingredient",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categorie_ingredient",
                table: "Ingredient");

            migrationBuilder.RenameColumn(
                name: "Descriere_categorie_ingredient",
                table: "CategorieIngredient",
                newName: "Descriere_IdCategorieIngredient");
        }
    }
}
