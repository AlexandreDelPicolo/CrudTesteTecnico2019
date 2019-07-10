using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTesteTecnico2019.Database.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CrudTesteTecnico");

            migrationBuilder.CreateTable(
                name: "Usuario_tb",
                schema: "CrudTesteTecnico",
                columns: table => new
                {
                    UsuarioId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 300, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Perfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_tb", x => x.UsuarioId);
                });

            migrationBuilder.InsertData(
                schema: "CrudTesteTecnico",
                table: "Usuario_tb",
                columns: new[] { "UsuarioId", "Nome", "Perfil", "Sobrenome", "DataNascimento", "Email" },
                values: new object[,]
                {
                    { 1L, "Alexandre", 4, "Del Picolo", new DateTime(2019, 7, 10, 19, 0, 50, 64, DateTimeKind.Local).AddTicks(5232), "administrator@administrator.com" },
                    { 2L, "Rafael", 1, "Garcia", new DateTime(1990, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(525), "rafaelfgx@gmail.com" },
                    { 3L, "Luciano", 3, "Lima", new DateTime(1992, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(915), "lucishow@gmail.com" },
                    { 4L, "Bruno", 3, "Lima", new DateTime(1992, 7, 10, 19, 0, 50, 69, DateTimeKind.Local).AddTicks(1223), "bruno.lima@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario_tb",
                schema: "CrudTesteTecnico");
        }
    }
}
