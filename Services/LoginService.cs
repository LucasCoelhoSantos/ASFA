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

    public async Task EsqueciMinhaSenhaAsync(string email)
    {
        // TO DO
        throw new NotImplementedException();
    }

    public async Task ObterPorEmailAsync(string email)
    {
        // TO DO
        throw new NotImplementedException();
        //return await _supabase.ObterPorEmailAsync(email);
    }
}
