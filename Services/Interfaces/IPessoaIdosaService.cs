using ASFA.Models;
using ASFA.Models.DTOs;
using System.Linq.Expressions;

namespace ASFA.Services.Interfaces;

public interface IPessoaIdosaService
{
    Task<IEnumerable<PessoaIdosaDataGridViewDTO>> ObterAsync(Expression<Func<PessoaIdosa, bool>>? filtro = null, int pagina = 1, int quantidadePorPagina = 50);
    Task<PessoaIdosa> ObterPorIdAsync(int id);
    Task CriarAsync(PessoaIdosa pessoaIdosa);
    Task EditarAsync(PessoaIdosa pessoaIdosa);
    Task<PessoaIdosa?> ObterPorCPFAsync(string cpf);
}
