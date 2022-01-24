using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class SomeModif20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reteta_Bucatar_BucatarId",
                table: "Reteta");

            migrationBuilder.DropTable(
                name: "Bucatar");

            migrationBuilder.DropIndex(
                name: "IX_Reteta_BucatarId",
                table: "Reteta");

            migrationBuilder.DropColumn(
                name: "BucatarId",
                table: "Reteta");

            migrationBuilder.DropColumn(
                name: "IdBucatar",
                table: "Reteta");

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

            migrationBuilder.AddColumn<Guid>(
                name: "BucatarId",
                table: "Reteta",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdBucatar",
                table: "Reteta",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Bucatar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nume_bucarat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pseudonume_bucarat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bucatar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reteta_BucatarId",
                table: "Reteta",
                column: "BucatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reteta_Bucatar_BucatarId",
                table: "Reteta",
                column: "BucatarId",
                principalTable: "Bucatar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
