using ASFA.Models;
using System.Linq.Expressions;

namespace ASFA.Repositories.Interfaces;

public interface IPessoaIdosaRepository
{
    Task<IEnumerable<PessoaIdosa>> ObterTodosAsync(Expression<Func<PessoaIdosa, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50);
    Task<PessoaIdosa> ObterPorIdAsync(int id);
    Task<PessoaIdosa> ObterPorCPFAsync(string cpf);
    Task CriarAsync(PessoaIdosa pessoaIdosa);
    Task EditarAsync(PessoaIdosa pessoaIdosa);
    Task InativarAsync(int id);
}
