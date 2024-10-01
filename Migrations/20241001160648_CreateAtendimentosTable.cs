using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SupportGestor.Migrations
{
    public partial class CreateAtendimentosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "atendimentos",
                columns: table => new
                {
                    AtendimentoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeAtendente = table.Column<string>(type: "text", nullable: false),
                    DataAtendimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NotasAtendimento = table.Column<string>(type: "text", nullable: false),
                    Cliente = table.Column<string>(type: "text", nullable: false),
                    Problema = table.Column<string>(type: "text", nullable: false),
                    NivelDificuldade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atendimentos", x => x.AtendimentoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atendimentos");
        }
    }
}
