using ASFA.Models;
using ASFA.Models.DTOs;
using ASFA.Repositories.Interfaces;
using ASFA.Services.Interfaces;
using AutoMapper;
using System.Linq.Expressions;

namespace ASFA.Services;

public class DependenteService : IDependenteService
{
    private readonly IDependenteRepository _dependenteRepository;
    private readonly IMapper _mapper;

    public DependenteService(IDependenteRepository dependenteRepository, IMapper mapper)
    {
        _dependenteRepository = dependenteRepository;
        _mapper = mapper;
    }

    public Task<IEnumerable<Dependente>> ObterAsync(Expression<Func<Dependente, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50)
    {
        throw new NotImplementedException();
    }

    public async Task<Dependente> ObterPorIdAsync(int id)
    {
        return await _dependenteRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Dependente>> ObterPorIdPessoaIdosaAsync(int id)
    {
        return await _dependenteRepository.ObterPorIdPessoaIdosaAsync(id);
    }

    public async Task CriarAsync(Dependente dependente)
    {
        await _dependenteRepository.CriarAsync(dependente);
    }

    public async Task EditarAsync(Dependente dependente)
    {
        await _dependenteRepository.EditarAsync(dependente);
    }

    public async Task InativarAsync(int id)
    {
        await _dependenteRepository.InativarAsync(id);
    }
}
