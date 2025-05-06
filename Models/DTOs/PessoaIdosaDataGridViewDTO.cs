namespace ASFA.Models.DTOs;

public class PessoaIdosaDataGridViewDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataNascimento { get; set; }
    public string EstadoCivil { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string OrgaoEmissor { get; set; }
    public string Religiao { get; set; }
    public string Naturalidade { get; set; }
    public Endereco Endereco { get; set; }
    public string Telefone { get; set; }
    public bool Ativo { get; set; }

    // Propriedades auxiliares
    public string Cep => Endereco?.Cep;
    public string Logradouro => Endereco?.Logradouro;
    public string Numero => Endereco?.Numero;
    public string Estado => Endereco?.Estado;
    public string Cidade => Endereco?.Cidade;
    public string Bairro => Endereco?.Bairro;
    public string Moradia => Endereco?.Moradia;
}
