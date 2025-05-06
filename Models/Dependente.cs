using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class Dependente : Pessoa
{
    [Required(ErrorMessage = "O campo parentesco é obrigatório.")]
    public string Parentesco { get; set; }

    public string Ceinf { get; set; }

    public string CeinfBairro { get; set; }

    public string ProgramaSaudePastoralCrianca { get; set; }

    public string ProgramaSaudePastoralCriancaLocal { get; set; }

    // Relacionamentos
    public int PessoaIdosaId { get; set; }

    [ForeignKey("PessoaIdosaId")]
    public virtual PessoaIdosa PessoaIdosa { get; set; }

    public void AtualizarCom(Dependente dependenteAtualizado)
    {
        Nome = dependenteAtualizado.Nome;
        DataNascimento = dependenteAtualizado.DataNascimento;
        Parentesco = dependenteAtualizado.Parentesco;
        Ceinf = dependenteAtualizado.Ceinf;
        CeinfBairro = dependenteAtualizado.CeinfBairro;
        ProgramaSaudePastoralCrianca = dependenteAtualizado.ProgramaSaudePastoralCrianca;
        ProgramaSaudePastoralCriancaLocal = dependenteAtualizado.ProgramaSaudePastoralCriancaLocal;
        Ativo = dependenteAtualizado.Ativo;

        if (ComposicaoFamiliar == null)
            ComposicaoFamiliar = dependenteAtualizado.ComposicaoFamiliar;
        else
            ComposicaoFamiliar.AtualizarCom(dependenteAtualizado.ComposicaoFamiliar);
    }
}
