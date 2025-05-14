using ASFA.Models;
using ASFA.Repositories.Connections;

namespace ASFA.Services;

public class LoginService
{
    private readonly Supabase _supabase;

    public LoginService(Supabase supabase)
    {
        _supabase = supabase;
    }

    public string Entrar(string email, string senha)
    {
        return _supabase.LoginUsuario(new Login { Email = email, Senha = senha });
    }

    public string Registrar(string email, string senha)
    {
        return _supabase.RegistrarUsuario(new Login { Email = email, Senha = senha });
        
    }

    public void EsqueciMinhaSenha(string email)
    {
        _supabase.EsqueciMinhaSenha(email);
    }
}
