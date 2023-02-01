using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(50)", nullable: false),
                    Instrucciones = table.Column<string>(nullable: false),
                    Ingredientes = table.Column<string>(nullable: false),
                    NombreAutor = table.Column<string>(type: "varchar(50)", nullable: false),
                    ApellidoAutor = table.Column<string>(type: "varchar(50)", nullable: false),
                    EdadAutor = table.Column<int>(nullable: false),
                    EmailAutor = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receta");
        }
    }
}
