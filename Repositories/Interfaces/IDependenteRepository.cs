using ASFA.Models;
using ASFA.Models.DTOs;
using System.Linq.Expressions;

namespace ASFA.Repositories.Interfaces;

public interface IDependenteRepository
{
    Task<IEnumerable<Dependente>> ObterTodosAsync(Expression<Func<Dependente, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50);
    Task<Dependente> ObterPorIdAsync(int id);
    Task<IEnumerable<Dependente>> ObterPorIdPessoaIdosaAsync(int id);
    Task CriarAsync(Dependente dependente);
    Task EditarAsync(Dependente dependente);
    Task InativarAsync(int id);
}
