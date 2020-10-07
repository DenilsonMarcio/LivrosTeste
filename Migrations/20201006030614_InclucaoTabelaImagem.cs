using Microsoft.EntityFrameworkCore.Migrations;

namespace LivrosTeste.Migrations
{
    public partial class InclucaoTabelaImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImagemId",
                table: "Livros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Imagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeImagem = table.Column<string>(nullable: true),
                    ImagemCapa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagem", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_ImagemId",
                table: "Livros",
                column: "ImagemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Imagem_ImagemId",
                table: "Livros",
                column: "ImagemId",
                principalTable: "Imagem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Imagem_ImagemId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Imagem");

            migrationBuilder.DropIndex(
                name: "IX_Livros_ImagemId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "ImagemId",
                table: "Livros");
        }
    }
}
