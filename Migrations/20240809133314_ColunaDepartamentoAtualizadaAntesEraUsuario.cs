using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrarUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class ColunaDepartamentoAtualizadaAntesEraUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Funcionarios",
                newName: "Departamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Departamento",
                table: "Funcionarios",
                newName: "Usuario");
        }
    }
}
