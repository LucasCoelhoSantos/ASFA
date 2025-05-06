using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class PessoaIdosa : Pessoa
{
    [Required(ErrorMessage = "O campo estado cívil é obrigatório.")]
    public string EstadoCivil { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório.")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O campo RG é obrigatório.")]
    public string Rg { get; set; }

    [Required(ErrorMessage = "O campo órgão emissor é obrigatório.")]
    public string OrgaoEmissor { get; set; }

    [Required(ErrorMessage = "O campo religião é obrigatória.")]
    public string Religiao { get; set; }

    [Required(ErrorMessage = "O campo naturalidade é obrigatória.")]
    public string Naturalidade { get; set; }

    [Required(ErrorMessage = "O campo telefone é obrigatório.")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O campo prontuário de saúde é obrigatório.")]
    public string ProntuarioSaude { get; set; }
    
    [Required(ErrorMessage = "O campo como aposentado consegue se manter com sua renda é obrigatório.")]
    public bool AposentadoConsegueSeManterComSuaRenda { get; set; }

    public string ComoComplementa { get; set; }

    public string Observacao { get; set; }

    public string HistoricoFamiliarSocial { get; set; }

    // Relacionamentos
    public int EnderecoId { get; set; }

    [ForeignKey("EnderecoId")]
    public virtual Endereco Endereco { get; set; }

    //[InverseProperty("PessoaIdosa")]
    //public virtual ICollection<Telefone> Telefones { get; set; } = [];

    [InverseProperty("PessoaIdosa")]
    public virtual ICollection<Dependente> Dependentes { get; set; } = [];

    public int AnexoId { get; set; }

    [InverseProperty("PessoaIdosa")]
    public virtual ICollection<Anexo> Anexos { get; set; } = [];

    protected PessoaIdosa() { }

    public static PessoaIdosa Criar(string nome, DateTime dataNascimento, string estadoCivil, string cpf, string rg, string orgaoEmissor, string religiao,
        string naturalidade, string telefone, string prontuarioSaude, bool aposentadoConsegueSeManterComSuaRenda, string comoComplementa, string observacao,
        string historicoFamiliarSocial, Endereco? endereco, bool ativo)
    {
        var pessoaIdosa = new PessoaIdosa();
        pessoaIdosa.DefinirDados(nome, dataNascimento, estadoCivil, cpf, rg, orgaoEmissor, religiao, naturalidade, telefone, prontuarioSaude,
            aposentadoConsegueSeManterComSuaRenda, comoComplementa, observacao, historicoFamiliarSocial, endereco, ativo);
        return pessoaIdosa;
    }

    public void AtualizarCom(PessoaIdosa outro)
    {
        DefinirDados(outro.Nome, outro.DataNascimento, outro.EstadoCivil, outro.Cpf, outro.Rg, outro.OrgaoEmissor, outro.Religiao, outro.Naturalidade,
            outro.Telefone, outro.ProntuarioSaude, outro.AposentadoConsegueSeManterComSuaRenda, outro.ComoComplementa, outro.Observacao,
            outro.HistoricoFamiliarSocial, outro.Endereco, outro.Ativo);
    }

    private void DefinirDados(string nome, DateTime dataNascimento, string estadoCivil, string cpf, string rg, string orgaoEmissor, string religiao,
        string naturalidade, string telefone, string prontuarioSaude, bool aposentadoConsegueSeManterComSuaRenda, string comoComplementa, string observacao,
        string historicoFamiliarSocial, Endereco endereco, bool ativo)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        EstadoCivil = estadoCivil;
        Cpf = cpf;
        Rg = rg;
        OrgaoEmissor = orgaoEmissor;
        Religiao = religiao;
        Naturalidade = naturalidade;
        Telefone = telefone;
        ProntuarioSaude = prontuarioSaude;
        AposentadoConsegueSeManterComSuaRenda = aposentadoConsegueSeManterComSuaRenda;
        ComoComplementa = comoComplementa;
        Observacao = observacao;
        HistoricoFamiliarSocial = historicoFamiliarSocial;
        Endereco = endereco;
        Ativo = ativo;
    }

    public void AdicionarDependente(Dependente dependente)
    {
        if (dependente != null)
            Dependentes.Add(dependente);
    }

    public void EditarDependente(Dependente dependenteEditado)
    {
        var dependenteExistente = Dependentes.FirstOrDefault(d => d.Id == dependenteEditado.Id);

        if (dependenteExistente == null)
            throw new InvalidOperationException("Dependente não encontrado");

        dependenteExistente.AtualizarCom(dependenteEditado);
    }

    public void RemoverDependente(int dependenteId)
    {
        var dependente = Dependentes.FirstOrDefault(d => d.Id == dependenteId);

        if (dependente != null)
            Dependentes.Remove(dependente);
    }

    public void AdicionarEditarAnexo(Anexo anexo)
    {
        var anexoExistente = Anexos.FirstOrDefault(a => a.TipoAnexo == anexo.TipoAnexo);

        if (anexoExistente != null)
            anexoExistente.AtualizarCom(anexo);
        else if (anexo != null)
            Anexos.Add(anexo);
    }

    public void RemoverAnexo(int anexoId)
    {
        var anexo = Anexos.FirstOrDefault(d => d.Id == anexoId);

        if (anexo != null)
            Anexos.Remove(anexo);
    }
}
