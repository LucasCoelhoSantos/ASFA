using ASFA.Models;
using System.Linq.Expressions;

namespace ASFA.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> ObterTodosAsync(Expression<Func<TEntity, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50, params Expression<Func<TEntity, object>>[] includes);
    Task<TEntity> ObterPorIdAsync(int id, params Expression<Func<TEntity, object>>[] includes);
    Task CriarAsync(TEntity entidade);
    Task EditarAsync(TEntity entidade);
    Task InativarAsync(int id);
}
