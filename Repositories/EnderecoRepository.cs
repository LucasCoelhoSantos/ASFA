using ASFA.Models;
using ASFA.Repositories.Connections;
using ASFA.Repositories.Interfaces;
using System.Data.Entity;

namespace ASFA.Repositories;

public class EnderecoRepository : IEnderecoRepository
{
    private readonly IBaseRepository<Endereco> _baseRepository;
    private readonly AppDbContext _dbContext;

    public EnderecoRepository(IBaseRepository<Endereco> baseRepository, AppDbContext dbContext)
    {
        _baseRepository = baseRepository;
        _dbContext = dbContext;
    }

    public async Task<Endereco> ObterPorIdAsync(int id)
    {
        return await _baseRepository.ObterPorIdAsync(id);
    }

    public async Task<Endereco> ObterPorIdPessoaIdosaAsync(int idPessoaIdosa)
    {
        return await _dbContext.Set<Endereco>().FirstOrDefaultAsync(e => e.Id == idPessoaIdosa);
    }
}
