using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class SomeModif3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nume_unitate",
                table: "Unitate",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_reteta",
                table: "Reteta",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_ingredient",
                table: "Ingredient",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Categorie_Retete",
                table: "CategorieReteta",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_categoriie_ingredient",
                table: "CategorieIngredient",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unitate_Nume_unitate",
                table: "Unitate",
                column: "Nume_unitate",
                unique: true,
                filter: "[Nume_unitate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reteta_Nume_reteta",
                table: "Reteta",
                column: "Nume_reteta",
                unique: true,
                filter: "[Nume_reteta] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Nume_ingredient",
                table: "Ingredient",
                column: "Nume_ingredient",
                unique: true,
                filter: "[Nume_ingredient] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieReteta_Nume_Categorie_Retete",
                table: "CategorieReteta",
                column: "Nume_Categorie_Retete",
                unique: true,
                filter: "[Nume_Categorie_Retete] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieIngredient_Nume_categoriie_ingredient",
                table: "CategorieIngredient",
                column: "Nume_categoriie_ingredient",
                unique: true,
                filter: "[Nume_categoriie_ingredient] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Unitate_Nume_unitate",
                table: "Unitate");

            migrationBuilder.DropIndex(
                name: "IX_Reteta_Nume_reteta",
                table: "Reteta");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_Nume_ingredient",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_CategorieReteta_Nume_Categorie_Retete",
                table: "CategorieReteta");

            migrationBuilder.DropIndex(
                name: "IX_CategorieIngredient_Nume_categoriie_ingredient",
                table: "CategorieIngredient");

            migrationBuilder.AlterColumn<string>(
                name: "Nume_unitate",
                table: "Unitate",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_reteta",
                table: "Reteta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_ingredient",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Categorie_Retete",
                table: "CategorieReteta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_categoriie_ingredient",
                table: "CategorieIngredient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
