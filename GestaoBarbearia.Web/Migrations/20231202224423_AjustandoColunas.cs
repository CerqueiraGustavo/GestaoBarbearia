using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoBarbearia.Web.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriçãoCorte",
                table: "Agendamento",
                newName: "Descricao");

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Agendamento",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Agendamento",
                newName: "DescriçãoCorte");
        }
    }
}
