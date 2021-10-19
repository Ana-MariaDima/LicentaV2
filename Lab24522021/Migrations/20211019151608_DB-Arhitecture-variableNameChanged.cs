using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class DBArhitecturevariableNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUnitati",
                table: "RetetaIngredient",
                newName: "IdUnitate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUnitate",
                table: "RetetaIngredient",
                newName: "IdUnitati");
        }
    }
}
