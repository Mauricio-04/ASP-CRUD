using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudNet7MVC.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial2Contacto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contactos",
                table: "Contactos");

            migrationBuilder.RenameTable(
                name: "Contactos",
                newName: "Contacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.RenameTable(
                name: "Contacto",
                newName: "Contactos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contactos",
                table: "Contactos",
                column: "Id");
        }
    }
}
