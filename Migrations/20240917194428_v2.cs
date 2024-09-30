using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrarUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoSenha",
                table: "Funcionarios",
                newName: "Senha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Funcionarios",
                newName: "TipoSenha");
        }
    }
}
