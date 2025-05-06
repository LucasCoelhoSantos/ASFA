using ASFA.Models;
using ASFA.Repositories.Interfaces;
using ASFA.Services.Interfaces;
using System.Linq.Expressions;

namespace ASFA.Services;

public class EnderecoService : IEnderecoService
{
    private readonly IEnderecoRepository _enderecoRepository;

    public EnderecoService(IEnderecoRepository enderecoRepository)
    {
        _enderecoRepository = enderecoRepository;
    }

    public async Task<IEnumerable<Endereco>> ObterAsync(Expression<Func<Endereco, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50)
    {
        throw new NotImplementedException();
        //return await _enderecoRepository.ObterAsync(filtro, pagina, quantidadePorPagina);
    }

    public async Task<Endereco> ObterPorIdAsync(int id)
    {
        return await _enderecoRepository.ObterPorIdAsync(id);
    }

    public async Task CriarAsync(Endereco endereco)
    {
        throw new NotImplementedException();
        //await _enderecoRepository.CriarAsync(endereco);
    }

    public async Task EditarAsync(Endereco endereco)
    {
        throw new NotImplementedException();
        //await _enderecoRepository.EditarAsync(endereco);
    }

    public async Task<Endereco> EditarPorIdPessoaIdosaAsync(int idPessoaIdosa, Endereco endereco)
    {
        throw new NotImplementedException();
        //return await _enderecoRepository.EditarPorIdPessoaIdosaAsync(idPessoaIdosa, endereco);
    }

    public async Task InativarAsync(int id)
    {
        throw new NotImplementedException();
        //await _enderecoRepository.InativarAsync(id);
    }
}
