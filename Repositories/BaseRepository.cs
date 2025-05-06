using ASFA.Models;
using ASFA.Repositories.Connections;
using ASFA.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ASFA.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
{
    protected readonly DbSet<TEntity> _dbSet;
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext dbContext)
    {
        _context = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> ObterTodosAsync(Expression<Func<TEntity, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50, params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _dbSet.AsQueryable();

        if (filtro != null)
            query = query.Where(filtro).AsNoTracking();

        foreach (var include in includes)
            query = query.Include(include);

        return await query
            .Skip((pagina - 1) * quantidadePorPagina)
            .Take(quantidadePorPagina)
            .ToListAsync();
    }

    public async Task<TEntity> ObterPorIdAsync(int id, params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _dbSet.AsQueryable();

        foreach (var include in includes)
            query = query.Include(include);

        var entity = await query.FirstOrDefaultAsync(e => e.Id == id);

        return entity;
    }

    public async Task CriarAsync(TEntity entidade)
    {
        await _dbSet.AddAsync(entidade);
        await _context.SaveChangesAsync();
    }

    public async Task EditarAsync(TEntity entidade)
    {
        var entidadeExistente = await _dbSet.FindAsync(entidade.Id) ?? throw new KeyNotFoundException("ID não encontrado para edição.");

        _dbSet.Entry(entidadeExistente).CurrentValues.SetValues(entidade);
        await _context.SaveChangesAsync();
    }

    public async Task InativarAsync(int id)
    {
        var entidadeExistente = await _dbSet.FindAsync(id) ?? throw new Exception($"ID não encontrado para edição.");
        throw new NotImplementedException();

        //_dbSet.Entry(entidadeExistente).CurrentValues.SetValues(entidade);
        //await _context.SaveChangesAsync();
    }
}
