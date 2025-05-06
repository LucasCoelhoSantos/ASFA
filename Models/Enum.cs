using System.ComponentModel;

namespace ASFA.Models;

public enum EstadoCivil
{
    [Description("Solteiro(a)")]
    Solteiro,

    [Description("Casado(a)")]
    Casado,

    [Description("Divorciado(a)")]
    Divorciado,

    [Description("Viúvo(a)")]
    Viuvo
}

public enum Beneficio
{
    [Description("Não")]
    Nao,

    [Description("Benefício de Prestação Continuada idoso")]
    BeneficioDePrestacaoContinuadaIdoso,

    [Description("Benefício de Prestação Continuada PcD")]
    BeneficioDePrestacaoContinuadaPcD,

    [Description("Programa Bolsa Família")]
    ProgramaBolsaFamilia,

    [Description("Pré Jovem")]
    PreJovem,

    [Description("Passe Social")]
    PasseSocial,

    Outro
}

public enum Renda
{
    [Description("Sem renda")]
    SemRenda,

    [Description("Até 1 salário mínimo")]
    Ate1SalarioMinimo,

    [Description("Até 2 salários mínimos")]
    Ate2SalariosMinimos,

    [Description("Acima de 2 salários mínimos")]
    AcimaDe2SalariosMinimos
}

public enum SituacaoOcupacional
{
    [Description("Assalariado c/ Carteira Assinada ou Funcionário Público")]
    AssalariadoCarteiraAssinadaOuFuncionarioPublico,

    [Description("Assalariado s/ Carteira Assinada")]
    AssalariadoSemarteiraAssinada,

    Aposentado,
    Pensionista,
    Diarista,

    [Description("Autônomo")]
    Autonomo,

    Aprendiz,

    [Description("Trabalho Informal (bico)")]
    TrabalhoInformal,

    Desempregado,
    Outro
}

public enum Aposentado
{
    [Description("Não")]
    Nao,

    [Description("Tempo de Serviço")]
    TempoDeServico,

    Proporcional,
    Invalidez,
    Funrural,
    Reserva,
    Outro
}

public enum Estado
{
    Acre,
    Alagoas,

    [Description("Amapá")]
    Amapa,

    Amazonas,
    Bahia,

    [Description("Ceará")]
    Ceara,

    [Description("Distrito Federal")]
    DistritoFederal,

    [Description("Espírito Santo")]
    EspíritoSanto,

    [Description("Goiás")]
    Goias,

    [Description("Maranhão")]
    Maranhao,

    [Description("Mato Grosso")]
    MatoGrosso,

    [Description("Mato Grosso do Sul")]
    MatoGrossoDoSul,

    [Description("Minas Gerais")]
    MinasGerais,

    [Description("Pará")]
    Para,

    [Description("Paraíba")]
    Paraiba,

    [Description("Paraná")]
    Parana,

    Pernambuco,

    [Description("Piauí")]
    Piaui,

    [Description("Rio de Janeiro")]
    RioDeJaneiro,

    [Description("Rio Grande do Norte")]
    RioGrandeDoNorte,

    [Description("Rio Grande do Sul")]
    RioGrandeDoSul,

    [Description("Rondônia")]
    Rondonia,

    Roraima,

    [Description("Santa Catarina")]
    SantaCatarina,

    [Description("São Paulo")]
    SaoPaulo,

    Sergipe,
    Tocantins
}

public enum Cidade
{
    //
}

public enum Moradia
{
    [Description("Própria")]
    Propria,

    Alugada,
    Cedida,
    Financiada
}

public enum Deficiencia
{
    [Description("Não")]
    Nao,
    
    [Description("Auditiva")]
    Auditiva,
    
    [Description("Visual")]
    Visual,
    
    [Description("Mental")]
    Mental,
    
    [Description("Física")]
    Fisica,
    
    [Description("Múltiplas")]
    Multiplas,
    
    [Description("Outra")]
    Outra
}

public enum NivelSerieAtualConcluido
{
    [Description("Educação Infantil")]
    EducacaoInfantil,

    [Description("Ensino Fundamental completo")]
    EnsinoFundamentalCompleto,

    [Description("Ensino Fundamental incompleto")]
    EnsinoFundamentalIncompleto,

    [Description("Ensino Médio completo")]
    EnsinoMedioCompleto,

    [Description("Ensino Médio incompleto")]
    EnsinoMedioIncompleto,

    [Description("Superior completo")]
    SuperiorCompleto,

    [Description("Superior incompleto")]
    SuperiorIncompleto
}

public enum CursoTecnicoFormacaoProfissional
{
    [Description("Técnico")]
    Tecnico,

    [Description("MOVA (Alfabetização)")]
    MOVA,

    [Description("EJA (Ensino de jovens e adultos)")]
    EJA,

    Outro
}

public enum ProblemaDeSaude
{
    [Description("Não")]
    Nao,

    Diabetes,
    Colesterol,

    [Description("Hipertensão")]
    Hipertensao,

    Renal,

    [Description("Cardíaca")]
    Cardiaca,

    Osteoporose,
    Artrose,
    Colunas,
    Epilepsia,
    HIV,

    [Description("Hanseníase")]
    Hanseniase,

    [Description("Alcoólatra")]
    Alcoolatra,

    [Description("Dependente químico")]
    DependenteQuimico,

    Outro
}

public enum TipoAnexo
{
    [Description("Foto de perfil")]
    FotoPerfil = 1,
    [Description("CPF")]
    Cpf = 2,
    [Description("RG")]
    Rg = 3,
    [Description("Comprovante de Endereço")]
    ComprovanteEndereco = 4,
    [Description("Cartão SUS")]
    CartaoSus = 5,
    [Description("Cadastro NIS")]
    CadastroNis = 6,
    [Description("Termo de Autorização")]
    TermoAutorizacao = 7
}
