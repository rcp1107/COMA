using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable
//SE genera base de datos con migración
namespace COMA.Migrations
{
    public partial class database : Migration
    {//En el método up se crea la tabla clientes así como sus columnas

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    correo_electronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    folio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saldo = table.Column<int>(type: "int", nullable: false),
                    fecha_facturacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_creacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "factura");
        }
    }
}
