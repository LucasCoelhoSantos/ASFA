namespace ASFA.Models.DTOs;

public class PessoaIdosaFichaDTO
{
    public int Id { get; set; }
    public DateTime DataCadastro { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string EstadoCivil { get; set; }
    public string Naturalidade { get; set; }
    public string ProntuarioSaude { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string OrgaoEmissor { get; set; }
    public string Religiao { get; set; }


    public bool AposentadoConsegueSeManterComSuaRenda { get; set; }
    public string ComoComplementa { get; set; }

    public Endereco Endereco { get; set; }
    public string Telefone { get; set; }


    public string Observacao { get; set; }
    public string HistoricoFamiliarSocial { get; set; }
    public bool Ativo { get; set; }

    // Relacionamentos
    public ComposicaoFamiliar ComposicaoFamiliar { get; set; }
    public List<Dependente> Dependentes { get; set; } = [];
    public List<Anexo> Anexos { get; set; } = [];
}
