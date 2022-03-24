using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDCaminhoes.Migrations
{
    public partial class Inicialcriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhoes",
                columns: table => new
                {
                    IdCaminhao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoFabricacao = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AnoModelo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhoes", x => x.IdCaminhao);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhoes");
        }
    }
}
