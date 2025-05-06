namespace ASFA.Models.DTOs;

public class PessoaIdosaMapper : IMapper<PessoaIdosa, PessoaIdosaFichaDTO>
{
    public PessoaIdosaFichaDTO Map(PessoaIdosa pessoaIdosa)
    {
        return new PessoaIdosaFichaDTO()
        {
            Ativo = true
        };
    }

    public IEnumerable<PessoaIdosaFichaDTO> Map(IEnumerable<PessoaIdosa> source)
    {
        foreach (var pessoaIdosa in source)
        {
            yield return Map(pessoaIdosa);
        }
    }
}
