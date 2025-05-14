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
            string resultadoRegistro = _loginService.Registrar(textEmail.Text, textSenha.Text);

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
            ValidacaoHelper.ValidarDadosLogin(textEmail.Text, textSenha.Text);

            string resultadoLogin = _loginService.Entrar(textEmail.Text, textSenha.Text);

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
            textEmail.Clear();
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
        
        try
        {
            _loginService.EsqueciMinhaSenha(email);

            MessageBoxHelper.ShowSuccess("Um e-mail foi enviado para redefinir sua senha.");
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao tentar redefinir a senha: {ex.Message}");
        }
    }

    private async void ButtonAtualizar_Click(object sender, EventArgs e)
    {
        await AtualizadorHelper.VerificarAtualizacaoAsync();
    }
}
