using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migracja1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grypy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grypy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudenta = table.Column<int>(type: "int", nullable: true),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdGrupy = table.Column<int>(type: "int", nullable: true),
                    TypAkcji = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historie_Grypy_IdGrupy",
                        column: x => x.IdGrupy,
                        principalTable: "Grypy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Studentci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGrupy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studentci_Grypy_IdGrupy",
                        column: x => x.IdGrupy,
                        principalTable: "Grypy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historie_IdGrupy",
                table: "Historie",
                column: "IdGrupy");

            migrationBuilder.CreateIndex(
                name: "IX_Studentci_IdGrupy",
                table: "Studentci",
                column: "IdGrupy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historie");

            migrationBuilder.DropTable(
                name: "Studentci");

            migrationBuilder.DropTable(
                name: "Grypy");
        }
    }
}
