using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ASFA.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataCadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    ComposicaoFamiliarId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComposicoesFamiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Alfabetizado = table.Column<bool>(type: "boolean", nullable: false),
                    EstudaAtualmente = table.Column<bool>(type: "boolean", nullable: false),
                    NivelSerieAtualConcluido = table.Column<string>(type: "text", nullable: false),
                    CursosTecnicoFormacaoProfissional = table.Column<string>(type: "text", nullable: false),
                    SituacaoOcupacional = table.Column<string>(type: "text", nullable: false),
                    Renda = table.Column<string>(type: "text", nullable: false),
                    Aposentado = table.Column<string>(type: "text", nullable: false),
                    Beneficio = table.Column<string>(type: "text", nullable: false),
                    Deficiencia = table.Column<string>(type: "text", nullable: false),
                    ProblemaDeSaude = table.Column<string>(type: "text", nullable: false),
                    FazAlgumTratamento = table.Column<bool>(type: "boolean", nullable: false),
                    FazAlgumTratamentoOnde = table.Column<string>(type: "text", nullable: false),
                    UsaMedicamentoControlado = table.Column<bool>(type: "boolean", nullable: false),
                    UsaRecursosUbsLocal = table.Column<bool>(type: "boolean", nullable: false),
                    TrabalhoPastoralOuSocial = table.Column<string>(type: "text", nullable: false),
                    AtividadeNaComunidadeSagradaFamilia = table.Column<string>(type: "text", nullable: false),
                    TrabalhoVoluntario = table.Column<string>(type: "text", nullable: false),
                    TrabalhoVoluntarioOnde = table.Column<string>(type: "text", nullable: false),
                    PessoaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComposicoesFamiliares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComposicoesFamiliares_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoasIdosas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    EstadoCivil = table.Column<string>(type: "text", nullable: false),
                    Cpf = table.Column<string>(type: "text", nullable: false),
                    Rg = table.Column<string>(type: "text", nullable: false),
                    OrgaoEmissor = table.Column<string>(type: "text", nullable: false),
                    Religiao = table.Column<string>(type: "text", nullable: false),
                    Naturalidade = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    ProntuarioSaude = table.Column<string>(type: "text", nullable: false),
                    AposentadoConsegueSeManterComSuaRenda = table.Column<bool>(type: "boolean", nullable: false),
                    ComoComplementa = table.Column<string>(type: "text", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: false),
                    HistoricoFamiliarSocial = table.Column<string>(type: "text", nullable: false),
                    EnderecoId = table.Column<int>(type: "integer", nullable: false),
                    AnexoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasIdosas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoasIdosas_Pessoas_Id",
                        column: x => x.Id,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipoAnexo = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    PessoaIdosaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anexos_PessoasIdosas_PessoaIdosaId",
                        column: x => x.PessoaIdosaId,
                        principalTable: "PessoasIdosas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Parentesco = table.Column<string>(type: "text", nullable: false),
                    Ceinf = table.Column<string>(type: "text", nullable: false),
                    CeinfBairro = table.Column<string>(type: "text", nullable: false),
                    ProgramaSaudePastoralCrianca = table.Column<string>(type: "text", nullable: false),
                    ProgramaSaudePastoralCriancaLocal = table.Column<string>(type: "text", nullable: false),
                    PessoaIdosaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependentes_PessoasIdosas_PessoaIdosaId",
                        column: x => x.PessoaIdosaId,
                        principalTable: "PessoasIdosas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dependentes_Pessoas_Id",
                        column: x => x.Id,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Moradia = table.Column<string>(type: "text", nullable: false),
                    PessoaIdosaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_PessoasIdosas_PessoaIdosaId",
                        column: x => x.PessoaIdosaId,
                        principalTable: "PessoasIdosas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexos_PessoaIdosaId",
                table: "Anexos",
                column: "PessoaIdosaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComposicoesFamiliares_PessoaId",
                table: "ComposicoesFamiliares",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dependentes_PessoaIdosaId",
                table: "Dependentes",
                column: "PessoaIdosaId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoaIdosaId",
                table: "Enderecos",
                column: "PessoaIdosaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "ComposicoesFamiliares");

            migrationBuilder.DropTable(
                name: "Dependentes");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "PessoasIdosas");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
