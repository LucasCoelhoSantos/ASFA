using ASFA.Models;
using ASFA.Models.DTOs;
using System.Linq.Expressions;

namespace ASFA.Services.Interfaces;

public interface IDependenteService
{
    Task<IEnumerable<Dependente>> ObterAsync(Expression<Func<Dependente, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50);
    Task<Dependente> ObterPorIdAsync(int id);
    Task<IEnumerable<Dependente>> ObterPorIdPessoaIdosaAsync(int idPessoaIdosa);
    Task CriarAsync(Dependente dependente);
    Task EditarAsync(Dependente dependente);
    Task InativarAsync(int id);
}
