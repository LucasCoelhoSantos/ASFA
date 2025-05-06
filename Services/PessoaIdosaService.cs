using ASFA.Models;
using ASFA.Models.DTOs;
using ASFA.Repositories.Interfaces;
using ASFA.Services.Interfaces;
using AutoMapper;
using System.Linq.Expressions;

namespace ASFA.Services;

public class PessoaIdosaService : IPessoaIdosaService
{
    private readonly IPessoaIdosaRepository _pessoaIdosaRepository;
    private readonly IMapper _mapper;

    public PessoaIdosaService(IPessoaIdosaRepository pessoaIdosaRepository, IMapper mapper)
    {
        _pessoaIdosaRepository = pessoaIdosaRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PessoaIdosaDataGridViewDTO>> ObterAsync(Expression<Func<PessoaIdosa, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50)
    {
        var resultado = await _pessoaIdosaRepository.ObterTodosAsync(filtro, pagina, quantidadePorPagina);
        return _mapper.Map<IEnumerable<PessoaIdosaDataGridViewDTO>>(resultado);
    }

    public async Task<PessoaIdosa> ObterPorIdAsync(int id)
    {
        return await _pessoaIdosaRepository.ObterPorIdAsync(id);
    }
    
    public async Task<PessoaIdosa?> ObterPorCPFAsync(string cpf)
    {
        return await _pessoaIdosaRepository.ObterPorCPFAsync(cpf);
    }

    public async Task CriarAsync(PessoaIdosa pessoaIdosa)
    {
        await _pessoaIdosaRepository.CriarAsync(pessoaIdosa);
    }

    public async Task EditarAsync(PessoaIdosa pessoaIdosa)
    {
        await _pessoaIdosaRepository.EditarAsync(pessoaIdosa);
    }
}
