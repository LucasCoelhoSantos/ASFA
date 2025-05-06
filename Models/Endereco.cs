using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class Endereco : Entity
{
    [Required(ErrorMessage = "O CEP � obrigat�rio.")]
    public string Cep { get; private set; }

    [Required(ErrorMessage = "O logradouro � obrigat�rio.")]
    public string Logradouro { get; private set; }

    [Required(ErrorMessage = "O n�mero � obrigat�rio.")]
    public string Numero { get; private set; }

    [Required(ErrorMessage = "O estado � obrigat�rio.")]
    public string Estado { get; private set; }

    [Required(ErrorMessage = "A cidade � obrigat�ria.")]
    public string Cidade { get; private set; }

    [Required(ErrorMessage = "O bairro � obrigat�rio.")]
    public string Bairro { get; private set; }

    [Required(ErrorMessage = "O tipo de moradia � obrigat�rio.")]
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
            throw new ArgumentException("CEP � obrigat�rio.");
        if (!System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{5}-\d{3}$") && !System.Text.RegularExpressions.Regex.IsMatch(cep, @"^\d{8}$"))
            throw new ArgumentException("CEP deve estar no formato 00000-000 ou 00000000.");
        if (string.IsNullOrWhiteSpace(logradouro))
            throw new ArgumentException("Logradouro � obrigat�rio.");
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("N�mero � obrigat�rio.");
        if (string.IsNullOrWhiteSpace(estado))
            throw new ArgumentException("Estado � obrigat�rio.");
        if (string.IsNullOrWhiteSpace(cidade))
            throw new ArgumentException("Cidade � obrigat�ria.");
        if (string.IsNullOrWhiteSpace(bairro))
            throw new ArgumentException("Bairro � obrigat�rio.");
        if (string.IsNullOrWhiteSpace(moradia))
            throw new ArgumentException("Moradia � obrigat�ria.");

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
