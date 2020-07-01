using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaJogos.Migrations
{
    public partial class AddCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Produto",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produto",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Produto",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "CategotiaId",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategotiaId",
                table: "Produto",
                column: "CategotiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategotiaId",
                table: "Produto",
                column: "CategotiaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategotiaId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategotiaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategotiaId",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produto",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produto",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produto",
                newName: "id");
        }
    }
}
