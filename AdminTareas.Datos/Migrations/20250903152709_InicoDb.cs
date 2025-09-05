using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdminTareas.Datos.Migrations
{
    /// <inheritdoc />
    public partial class InicoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoTareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTareas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrioridadTareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrioridadTareas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Prioridad = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCompromiso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notas = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EstadoTareas",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Tarea pendiente de iniciar", "PENDIENTE" },
                    { 2, "Tarea en proceso", "EN_PROCESO" },
                    { 3, "Tarea completada", "FINALIZADA" }
                });

            migrationBuilder.InsertData(
                table: "PrioridadTareas",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Prioridad alta", "ALTA" },
                    { 2, "Prioridad media", "MEDIA" },
                    { 3, "Prioridad baja", "BAJA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoTareas");

            migrationBuilder.DropTable(
                name: "PrioridadTareas");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
