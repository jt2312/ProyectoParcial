using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuarioo = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    fechanacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    genero = table.Column<string>(type: "TEXT", nullable: false),
                    documento = table.Column<int>(type: "INTEGER", nullable: false),
                    nacionalidad = table.Column<string>(type: "TEXT", nullable: false),
                    domicilio = table.Column<string>(type: "TEXT", nullable: false),
                    telefono = table.Column<int>(type: "INTEGER", nullable: false),
                    terminos = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
