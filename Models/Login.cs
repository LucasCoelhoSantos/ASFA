using System.ComponentModel.DataAnnotations;

namespace ASFA.Models;

public class Login
{
    public string? Token { get; set; }
    [Required(ErrorMessage = "O campo email é obrigatório.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "O campo senha é obrigatório.")]
    public string Senha { get; set; }
}
