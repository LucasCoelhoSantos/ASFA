using ASFA.Models;
using System.Linq.Expressions;

namespace ASFA.Services.Interfaces;

public interface IEnderecoService
{
    // object dto
    Task<IEnumerable<Endereco>> ObterAsync(Expression<Func<Endereco, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50);
    Task<Endereco> ObterPorIdAsync(int id);
    Task CriarAsync(Endereco dependente);
    Task EditarAsync(Endereco dependente);
    Task InativarAsync(int id);
    Task<Endereco> EditarPorIdPessoaIdosaAsync(int idPessoaIdosa, Endereco endereco);
}
