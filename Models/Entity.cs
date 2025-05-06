using System.ComponentModel.DataAnnotations;

namespace ASFA.Models;

public abstract class Entity
{
    [Key]
    public int Id { get; set; }

    //public DateTime DataInclusao { get; set; } = DateTime.UtcNow;
    //public string UsuarioInclusao { get; set; }
    //public DateTime? DataAlteracao { get; set; }
    //public string UsuarioAlteracao { get; set; }
    //public bool Ativo { get; set; }
}
