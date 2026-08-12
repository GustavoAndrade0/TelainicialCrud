using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelainicialCrud.Migrations
{
    /// <inheritdoc />
    public partial class CriandoProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projetoas",
                columns: table => new
                {
                    IdProjetoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjetoaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<int>(type: "int", nullable: false),
                    DataFinal = table.Column<int>(type: "int", nullable: false),
                    QuantPessoas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetoas", x => x.IdProjetoa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projetoas");
        }
    }
}
