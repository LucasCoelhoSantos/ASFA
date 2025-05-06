using ASFA.Models;
using ASFA.Repositories.Connections;
using ASFA.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ASFA.Repositories;

public class PessoaIdosaRepository : IPessoaIdosaRepository
{
    private readonly IBaseRepository<PessoaIdosa> _baseRepository;
    private readonly DbSet<PessoaIdosa> _dbSet;

    public PessoaIdosaRepository(IBaseRepository<PessoaIdosa> baseRepository, AppDbContext dbContext)
    {
        _baseRepository = baseRepository;
        _dbSet = dbContext.Set<PessoaIdosa>();
    }

    public async Task<IEnumerable<PessoaIdosa>> ObterTodosAsync(Expression<Func<PessoaIdosa, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50)
    {
        return await _baseRepository.ObterTodosAsync(filtro, pagina, quantidadePorPagina, p => p.Endereco, p => p.ComposicaoFamiliar, p => p.Anexos);
    }

    public async Task<PessoaIdosa> ObterPorIdAsync(int id)
    {
        var query = _dbSet
            .Include(p => p.Endereco)
            .Include(p => p.ComposicaoFamiliar)
            .Include(p => p.Anexos)
            .Include(p => p.Dependentes)
                .ThenInclude(d => d.ComposicaoFamiliar);

        return await query.FirstOrDefaultAsync(p => p.Id == id);

        //return await _baseRepository.ObterPorIdAsync(id, p => p.Endereco, p => p.ComposicaoFamiliar, p => p.Anexos, p => p.Dependentes, p => p.Dependentes.Select(d => d.ComposicaoFamiliar));
    }

    public async Task<PessoaIdosa> ObterPorCPFAsync(string cpf)
    {
        return await _dbSet.FirstOrDefaultAsync(p => p.Cpf == cpf);
    }

    public async Task CriarAsync(PessoaIdosa pessoaIdosa)
    {
        await _baseRepository.CriarAsync(pessoaIdosa);
    }

    public async Task EditarAsync(PessoaIdosa pessoaIdosa)
    {
        await _baseRepository.EditarAsync(pessoaIdosa);
    }

    public async Task InativarAsync(int id)
    {
        await _baseRepository.InativarAsync(id);
    }
}
