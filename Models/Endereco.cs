using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class Endereco : Entity
{
    [Required(ErrorMessage = "O CEP é obrigatório.")]
    public string Cep { get; private set; }

    [Required(ErrorMessage = "O logradouro é obrigatório.")]
    public string Logradouro { get; private set; }

    [Required(ErrorMessage = "O número é obrigatório.")]
    public string Numero { get; private set; }

    [Required(ErrorMessage = "O estado é obrigatório.")]
    public string Estado { get; private set; }

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    public string Cidade { get; private set; }

    [Required(ErrorMessage = "O bairro é obrigatório.")]
    public string Bairro { get; private set; }

    [Required(ErrorMessage = "O tipo de moradia é obrigatório.")]
    public string Moradia { get; private set; }

    // Relacionamentos
    public int PessoaIdosaId { get; set; }

    [ForeignKey("PessoaIdosaId")]
    public PessoaIdosa PessoaIdosa { get; set; }

    protected Endereco() { }

    public static Endereco Criar(string cep, string logradouro, string numero, string estado, string cidade, string bairro, string moradia)
    {
        var endereco = new Endereco();
        endereco.DefinirDados(cep, logradouro, numero, estado, cidade, bairro, moradia);
        return endereco;
    }

    public void AtualizarCom(Endereco outro)
    {
        DefinirDados(outro.Cep, outro.Logradouro, outro.Numero, outro.Estado, outro.Cidade, outro.Bairro, outro.Moradia);
    }

    private void DefinirDados(string cep, string logradouro, string numero, string estado, string cidade, string bairro, string moradia)
    {
        if (string.IsNullOrWhiteSpace(cep))
            throw new ArgumentException("CEP é obrigatório.");
        if (!System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{5}-\d{3}$") && !System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{8}$"))
            throw new ArgumentException("CEP deve estar no formato 00000-000 ou 00000000.");
        if (string.IsNullOrWhiteSpace(logradouro))
            throw new ArgumentException("Logradouro é obrigatório.");
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("Número é obrigatório.");
        if (string.IsNullOrWhiteSpace(estado))
            throw new ArgumentException("Estado é obrigatório.");
        if (string.IsNullOrWhiteSpace(cidade))
            throw new ArgumentException("Cidade é obrigatória.");
        if (string.IsNullOrWhiteSpace(bairro))
            throw new ArgumentException("Bairro é obrigatório.");
        if (string.IsNullOrWhiteSpace(moradia))
            throw new ArgumentException("Moradia é obrigatória.");

        Cep = cep.Trim();
        Logradouro = logradouro.Trim();
        Numero = numero.Trim();
        Estado = estado.Trim();
        Cidade = cidade.Trim();
        Bairro = bairro.Trim();
        Moradia = moradia.Trim();
    }
}

public class EnderecoViaCep
{
    public string Cep { get; set; }
    public string Estado { get; set; }
    public string Localidade { get; set; }
    public string Bairro { get; set; }
    public string Logradouro { get; set; }
}
