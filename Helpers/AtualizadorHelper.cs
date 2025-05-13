using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace ASFA.Helpers;

public class AtualizadorHelper
{
    private const string VersionJsonUrl = "https://raw.githubusercontent.com/LucasCoelhoSantos/ASFA/main/version.json";
    private static readonly string VersaoAtual = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public static async Task VerificarAtualizacaoAsync()
    {
        try
        {
            using var http = new HttpClient();
            var json = await http.GetStringAsync(VersionJsonUrl);

            var doc = JsonDocument.Parse(json);
            var novaVersao = doc.RootElement.GetProperty("version").GetString();
            var url = doc.RootElement.GetProperty("url").GetString();

            if (novaVersao != VersaoAtual)
            {
                if (MessageBoxHelper.ShowUpdateOption($"Uma nova versão está disponível ({novaVersao}). Deseja atualizar agora?") == DialogResult.Yes)
                {
                    var nomeExe = Path.GetFileName(url);
                    var caminhoTemp = Path.Combine(Path.GetTempPath(), nomeExe);

                    using var stream = await http.GetStreamAsync(url);
                    using var fs = new FileStream(caminhoTemp, FileMode.Create);
                    await stream.CopyToAsync(fs);

                    Process.Start(caminhoTemp);
                    Application.Exit();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError("Erro ao verificar atualização: " + ex.Message);
        }
    }
}
