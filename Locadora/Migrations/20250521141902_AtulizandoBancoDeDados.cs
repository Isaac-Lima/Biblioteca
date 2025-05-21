using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Locadora.Migrations
{
    /// <inheritdoc />
    public partial class AtulizandoBancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Livros",
                newName: "AutorIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorId",
                table: "Livros",
                newName: "IX_Livros_AutorIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorIdId",
                table: "Livros",
                column: "AutorIdId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorIdId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "AutorIdId",
                table: "Livros",
                newName: "AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Livros_AutorIdId",
                table: "Livros",
                newName: "IX_Livros_AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
