using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace ASFA.Helpers;

public class AtualizadorHelper
{
    private const string VersionJsonUrl = "https://raw.githubusercontent.com/LucasCoelhoSantos/ASFA/main/version.json";

    public static async Task VerificarAtualizacaoAsync()
    {
        try
        {
            var versaoAtual = Assembly.GetExecutingAssembly().GetName().Version;
            
            if (versaoAtual == null)
                throw new Exception("Não foi possível obter a versão atual.");

            using var http = new HttpClient();
            var json = await http.GetStringAsync(VersionJsonUrl);
            var doc = JsonDocument.Parse(json);

            var versaoNovaStr = doc.RootElement.GetProperty("version").GetString();
            var urlDownload = doc.RootElement.GetProperty("url").GetString();

            if (!Version.TryParse(versaoNovaStr, out var versaoNova))
                throw new Exception("Formato de versão inválido no version.json.");
            //
            if (versaoNova != versaoAtual)
            {
                if (MessageBoxHelper.ShowUpdateOption($"Uma nova versão está disponível: {versaoNova}.\nVersão instalada: {versaoAtual}\nDeseja atualizar agora?") == DialogResult.Yes && urlDownload != null)
                {
                    var caminhoTemp = Path.Combine(Path.GetTempPath(), Path.GetFileName(urlDownload));

                    using var stream = await http.GetStreamAsync(urlDownload);
                    using var fs = new FileStream(caminhoTemp, FileMode.Create);
                    await stream.CopyToAsync(fs);

                    var startInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C timeout /t 2 & start \"\" \"{caminhoTemp}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };

                    Process.Start(startInfo);
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
