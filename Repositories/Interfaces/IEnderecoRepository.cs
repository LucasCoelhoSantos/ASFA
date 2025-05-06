using ASFA.Models;

namespace ASFA.Repositories.Interfaces;

public interface IEnderecoRepository
{
    Task<Endereco> ObterPorIdAsync(int id);
    Task<Endereco> ObterPorIdPessoaIdosaAsync(int id);
}
