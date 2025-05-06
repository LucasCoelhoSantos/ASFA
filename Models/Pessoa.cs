using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASFA.Models;

public class Pessoa : Entity
{
    [Required]
    public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

    [Required(ErrorMessage = "O campo nome é obrigatório.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo data de nascimento é obrigatória.")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O campo ativo é obrigatório.")]
    public bool Ativo { get; set; }

    // Relacionamentos
    public int ComposicaoFamiliarId { get; set; }
    [ForeignKey("ComposicaoFamiliarId")]
    public virtual ComposicaoFamiliar ComposicaoFamiliar { get; set; }
}
