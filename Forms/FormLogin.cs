using ASFA.Helpers;
using ASFA.Services;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;

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

        string sql = "SELECT id, nome, data_nascimento FROM Pessoa";
        /*using var cmd = new NpgsqlCommand(sql, _dbConnection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Nascimento: {reader["data_nascimento"]}");
        }*/
    }

    private async void ButtonAtualizar_Click(object sender, EventArgs e)
    {
        await CheckUpdateAsync();
    }

    private async Task CheckUpdateAsync()
    {
        await AtualizadorHelper.VerificarAtualizacaoAsync();

        // TO FIX armazenar versaoAtual em algum lugar
        //var VersaoAtual1 = Assembly.GetExecutingAssembly().GetName().Version;
        //var VersaoAtual2 = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "0.0.0";
        
        //string VersaoAtual = "v1.0.0";
        //string RepoApiUrl = "https://api.github.com/repos/LucasCoelhoSantos/ASFA/releases/latest";

        //try
        //{
        //    using var http = new HttpClient();
        //    http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyAppUpdater", "1.0"));

        //    var json = await http.GetStringAsync(RepoApiUrl);
        //    var release = JsonDocument.Parse(json).RootElement;
        //    var ultimaVersao = release.GetProperty("tag_name").GetString();

        //    if (ultimaVersao != VersaoAtual)
        //    {
        //        var asset = release.GetProperty("assets")[0];
        //        var nomeArquivo = asset.GetProperty("name").GetString();
        //        var urlDownload = asset.GetProperty("browser_download_url").GetString();

        //        var caminhoArquivo = Path.Combine(Path.GetTempPath(), nomeArquivo);

        //        using var resposta = await http.GetAsync(urlDownload);

        //        await using var fs = new FileStream(caminhoArquivo, FileMode.Create);
        //        await resposta.Content.CopyToAsync(fs);

        //        Process.Start(new ProcessStartInfo
        //        {
        //            FileName = "msiexec",
        //            Arguments = $"/i \"{caminhoArquivo}\" /passive",
        //            UseShellExecute = true,
        //            Verb = "runas"
        //        });

        //        Environment.Exit(0);
        //    }
        //    else
        //    {
        //        MessageBoxHelper.ShowWarning("Você já está usando a versão mais recente!");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBoxHelper.ShowError(ex.Message);
        //}
    }
}
