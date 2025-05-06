using ASFA.Models;
using ASFA.Models.DTOs;
using ASFA.Repositories.Connections;
using ASFA.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ASFA.Repositories;

public class DependenteRepository : IDependenteRepository
{
    private readonly IBaseRepository<Dependente> _baseRepository;
    private readonly AppDbContext _dbContext;

    public DependenteRepository(IBaseRepository<Dependente> baseRepository, AppDbContext dbContext)
    {
        _baseRepository = baseRepository;
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Dependente>> ObterTodosAsync(Expression<Func<Dependente, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50)
    {
        return await _baseRepository.ObterTodosAsync(filtro, pagina, quantidadePorPagina, d => d.ComposicaoFamiliar);
    }

    public async Task<Dependente> ObterPorIdAsync(int id)
    {
        return await _baseRepository.ObterPorIdAsync(id, d => d.ComposicaoFamiliar);
    }

    public async Task<IEnumerable<Dependente>> ObterPorIdPessoaIdosaAsync(int idPessoaIdosa)
    {
        return await _dbContext.Set<Dependente>()
            .Where(d => d.PessoaIdosaId == idPessoaIdosa)
            .Include(d => d.ComposicaoFamiliar)
            .ToListAsync();
    }

    public async Task CriarAsync(Dependente dependente)
    {
        await _baseRepository.CriarAsync(dependente);
    }

    public async Task EditarAsync(Dependente dependente)
    {
        await _baseRepository.EditarAsync(dependente);
    }

    public async Task InativarAsync(int id)
    {
        //await _dbContext.Set<Dependente>().editar(inativar);
        await _baseRepository.InativarAsync(id);
    }
}
