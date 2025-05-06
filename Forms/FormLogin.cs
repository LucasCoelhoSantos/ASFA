using ASFA.Helpers;
using ASFA.Services;
using System.Diagnostics;

namespace ASFA;

public partial class FormLogin : Form
{
    private readonly LoginService _loginService;
    private static readonly HttpClient httpClient = new HttpClient();

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
        // TO DO
        try
        {
            // URL do version.txt no GitHub (exemplo)
            var versionUrl = "https://raw.githubusercontent.com/usuario/repositorio/main/versin.txt";
            var setupUrl = "https://github.com/usuario/repositorio/releases/v1.2.3/setup.exe";

            // Obter a nova versão
            var versionString = await httpClient.GetStringAsync(versionUrl);
            var newVersion = new Version(versionString.Trim());
            var currentVersion = new Version(Application.ProductVersion);

            if (newVersion > currentVersion)
            {
                MessageBox.Show("Nova versão disponível! O download será iniciado.");

                var filePath = Path.Combine(Path.GetTempPath(), "update.exe");

                using var response = await httpClient.GetAsync(setupUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                var canReportProgress = totalBytes != -1;

                await using var contentStream = await response.Content.ReadAsStreamAsync();
                await using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);

                var buffer = new byte[81920];
                long totalRead = 0L;
                int read;

                while ((read = await contentStream.ReadAsync(buffer.AsMemory(0, buffer.Length))) > 0)
                {
                    await fileStream.WriteAsync(buffer.AsMemory(0, read));
                    totalRead += read;

                    if (canReportProgress)
                    {
                        int progress = (int)(totalRead * 100 / totalBytes);
                        //pbDownload.Invoke(() => pbDownload.Value = progress);
                        //lblDownload.Invoke(() => lblDownload.Text = $"{totalRead / 1024 / 1024}MB / {totalBytes / 1024 / 1024}MB");
                    }
                }

                Process.Start(filePath);
                Process.GetCurrentProcess().Kill();
            }
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }
}
