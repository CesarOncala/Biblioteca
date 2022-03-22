using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Biblioteca.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editora",
                columns: table => new
                {
                    CodEdi = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomEdi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editora", x => x.CodEdi);
                });

            migrationBuilder.CreateTable(
                name: "Obra",
                columns: table => new
                {
                    CodObr = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomObr = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obra", x => x.CodObr);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    CodPais = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomPais = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.CodPais);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    TipUsu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DesTipUsu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.TipUsu);
                });

            migrationBuilder.CreateTable(
                name: "Exemplar",
                columns: table => new
                {
                    CodObr = table.Column<int>(type: "integer", nullable: false),
                    NumExe = table.Column<int>(type: "integer", nullable: false),
                    CodEdi = table.Column<int>(type: "integer", nullable: false),
                    ValorExe = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplar", x => new { x.CodObr, x.NumExe });
                    table.ForeignKey(
                        name: "FK_Exemplar_Editora_CodEdi",
                        column: x => x.CodEdi,
                        principalTable: "Editora",
                        principalColumn: "CodEdi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exemplar_Obra_CodObr",
                        column: x => x.CodObr,
                        principalTable: "Obra",
                        principalColumn: "CodObr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    CodAut = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomAut = table.Column<string>(type: "text", nullable: true),
                    CodPai = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.CodAut);
                    table.ForeignKey(
                        name: "FK_Autor_Pais_CodPai",
                        column: x => x.CodPai,
                        principalTable: "Pais",
                        principalColumn: "CodPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    CodUsu = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomUsu = table.Column<string>(type: "text", nullable: true),
                    SexoUsu = table.Column<char>(type: "character(1)", nullable: false),
                    TipUsu = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.CodUsu);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_TipUsu",
                        column: x => x.TipUsu,
                        principalTable: "TipoUsuario",
                        principalColumn: "TipUsu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autoria",
                columns: table => new
                {
                    CodObr = table.Column<int>(type: "integer", nullable: false),
                    CodAut = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autoria", x => new { x.CodAut, x.CodObr });
                    table.ForeignKey(
                        name: "FK_Autoria_Autor_CodAut",
                        column: x => x.CodAut,
                        principalTable: "Autor",
                        principalColumn: "CodAut",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Autoria_Obra_CodObr",
                        column: x => x.CodObr,
                        principalTable: "Obra",
                        principalColumn: "CodObr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimo",
                columns: table => new
                {
                    CodObr = table.Column<int>(type: "integer", nullable: false),
                    NumExe = table.Column<int>(type: "integer", nullable: false),
                    CodUsu = table.Column<int>(type: "integer", nullable: false),
                    DatIni = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DatFim = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DatDev = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimo", x => new { x.CodObr, x.NumExe, x.CodUsu, x.DatIni });
                    table.ForeignKey(
                        name: "FK_Emprestimo_Exemplar_NumExe_CodObr",
                        columns: x => new { x.NumExe, x.CodObr },
                        principalTable: "Exemplar",
                        principalColumns: new[] { "CodObr", "NumExe" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Obra_CodObr",
                        column: x => x.CodObr,
                        principalTable: "Obra",
                        principalColumn: "CodObr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Usuario_CodUsu",
                        column: x => x.CodUsu,
                        principalTable: "Usuario",
                        principalColumn: "CodUsu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_CodPai",
                table: "Autor",
                column: "CodPai");

            migrationBuilder.CreateIndex(
                name: "IX_Autoria_CodObr",
                table: "Autoria",
                column: "CodObr");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_CodUsu",
                table: "Emprestimo",
                column: "CodUsu");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_NumExe_CodObr",
                table: "Emprestimo",
                columns: new[] { "NumExe", "CodObr" });

            migrationBuilder.CreateIndex(
                name: "IX_Exemplar_CodEdi",
                table: "Exemplar",
                column: "CodEdi");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipUsu",
                table: "Usuario",
                column: "TipUsu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autoria");

            migrationBuilder.DropTable(
                name: "Emprestimo");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Exemplar");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Editora");

            migrationBuilder.DropTable(
                name: "Obra");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
