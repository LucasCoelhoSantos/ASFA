using ASFA.Helpers;
using ASFA.Services;

namespace ASFA;

public partial class FormLogin : Form
{
    private readonly LoginService _loginService;

    public FormLogin(LoginService loginService)
    {
        _loginService = loginService;

        InitializeComponent();
    }

    private void ButtonRegistrar_Click(object sender, EventArgs e)
    {
        try
        {
            ValidacaoHelper.ValidarDadosLogin(textLogin.Text, textSenha.Text);

            string senhaHash = BCrypt.Net.BCrypt.HashPassword(textSenha.Text);

            string resultadoRegistro = _loginService.Registrar(textLogin.Text, senhaHash);

            if (resultadoRegistro.Contains("Erro"))
            {
                MessageBoxHelper.ShowError(resultadoRegistro);
                return;
            }

            MessageBoxHelper.ShowSuccess(resultadoRegistro);
        }
        catch (ArgumentException ex)
        {
            MessageBoxHelper.ShowWarning($"Entrada inválida: {ex.Message}");
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao registrar: {ex.Message}");
        }
    }

    private void ButtonEntrar_Click(object sender, EventArgs e)
    {
        try
        {
            ValidacaoHelper.ValidarDadosLogin(textLogin.Text, textSenha.Text);

            string senhaHash = BCrypt.Net.BCrypt.HashPassword(textSenha.Text);

            string resultadoLogin = _loginService.Entrar(textLogin.Text, senhaHash);

            if (resultadoLogin.Contains("Erro"))
            {
                MessageBoxHelper.ShowError($"Erro ao logar: {resultadoLogin}");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (ArgumentException ex)
        {
            MessageBoxHelper.ShowWarning($"Entrada inválida: {ex.Message}");
            textLogin.Clear();
            textSenha.Clear();
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao logar: {ex.Message}");
        }
    }

    private void ButtonEsqueciMinhaSenha_Click(object sender, EventArgs e)
    {
        string email = textEmail.Text.Trim();

        if (string.IsNullOrEmpty(email))
        {
            MessageBoxHelper.ShowWarning("Por favor, insira seu e-mail.");
            return;
        }
        /*
        using (var contexto = new Context())
        {
            //
        }
        */
        try
        {
            MessageBoxHelper.ShowSuccess("Um e-mail foi enviado para redefinir sua senha.");
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao tentar redefinir a senha: {ex.Message}");
        }

        /*string sql = "SELECT id, nome, data_nascimento FROM Pessoa";
        using var cmd = new NpgsqlCommand(sql, _dbConnection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Nascimento: {reader["data_nascimento"]}");
        }*/
    }

    private async void ButtonAtualizar_Click(object sender, EventArgs e)
    {
        await AtualizadorHelper.VerificarAtualizacaoAsync();
    }
}
