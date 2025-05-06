using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace ASFA.Helpers;

public class GoogleDriveHelper
{
    private DriveService _driveService;

    public GoogleDriveHelper()
    {
        Inicializar();
    }

    private void Inicializar()
    {
        string[] Scopes = { DriveService.Scope.Drive };
        string ApplicationName = "Asfa";

        UserCredential credential;

        // Arquivo client_secret.json obtido do Google Cloud Console
        using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
        {
            string credPath = "token.json";
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;
        }

        _driveService = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });
    }

    public void AdicionarArquivo(string cpf, string pastaDrive, out string? nomeArquivo, out string? urlArquivo)
    {
        urlArquivo = null;
        nomeArquivo = null;

        if (string.IsNullOrWhiteSpace(cpf))
        {
            MessageBoxHelper.ShowWarning("Insira o CPF antes de carregar um arquivo");
            return;
        }

        OpenFileDialog arquivoSelecionado = new()
        {
            Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png"
        };

        if (arquivoSelecionado.ShowDialog() == DialogResult.OK)
        {
            try
            {
                nomeArquivo = arquivoSelecionado.SafeFileName;
                string caminhoComprimido = new ManipularArquivoHelper().ComprimirImagem(arquivoSelecionado.FileName, ManipularArquivoHelper.CalcularHash(cpf));
                urlArquivo = UploadArquivo(caminhoComprimido, pastaDrive);

                File.Delete(caminhoComprimido);
                MessageBoxHelper.ShowSuccess("Imagem enviada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Erro ao processar a imagem: {ex.Message}");
            }
        }
    }

    public string UploadArquivo(string caminhoArquivo, string? nomePasta = null)
    {
        try
        {
            string nomeArquivo = Path.GetFileName(caminhoArquivo);
            string? pastaId = null;

            if (!string.IsNullOrEmpty(nomePasta))
                pastaId = ObterIdPastaPeloNome(nomePasta);

            string arquivoExistenteId = BuscarArquivoExistente(nomeArquivo, pastaId);

            if (!string.IsNullOrEmpty(arquivoExistenteId))
                return AtualizarArquivoExistente(arquivoExistenteId, caminhoArquivo);

            return UploadNovoArquivo(caminhoArquivo, nomeArquivo, pastaId);
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao salvar imagem: {ex.Message}");
        }
    }

    private string ObterIdPastaPeloNome(string nomePasta)
    {
        string query = $"name = '{nomePasta}' and mimeType = 'application/vnd.google-apps.folder' and trashed = false";
        var request = _driveService.Files.List();
        request.Q = query;
        request.Fields = "files(id, name)";

        var resultado = request.Execute();
        var pastas = resultado.Files;

        if (pastas != null && pastas.Count > 0)
        {
            // Retorna o ID da primeira pasta encontrada com esse nome
            return pastas[0].Id;
        }

        // Se não encontrou, cria a pasta
        return CriarPasta(nomePasta);
    }

    private string CriarPasta(string nomePasta)
    {
        var metadados = new Google.Apis.Drive.v3.Data.File()
        {
            Name = nomePasta,
            MimeType = "application/vnd.google-apps.folder"
        };

        var request = _driveService.Files.Create(metadados);
        request.Fields = "id";
        var pasta = request.Execute();

        return pasta.Id;
    }

    private string? BuscarArquivoExistente(string nomeArquivo, string pastaId)
    {
        string query = $"name contains '{nomeArquivo}' and trashed = false";

        if (!string.IsNullOrEmpty(pastaId))
            query += $" and '{pastaId}' in parents";

        var request = _driveService.Files.List();
        request.Q = query;
        request.Fields = "files(id, name)";

        var resultado = request.Execute();
        var arquivos = resultado.Files;

        if (arquivos != null && arquivos.Count > 0)
            return arquivos[0].Id;

        return null;
    }

    private string AtualizarArquivoExistente(string arquivoId, string caminhoArquivo)
    {
        using (var stream = new FileStream(caminhoArquivo, FileMode.Open))
        {
            // Não precisamos atualizar metadados, apenas o conteúdo
            var updateRequest = _driveService.Files.Update(null, arquivoId, stream, GetMimeType(caminhoArquivo));
            updateRequest.Upload();

            // Garantir que o arquivo é público
            var permission = new Google.Apis.Drive.v3.Data.Permission
            {
                Type = "anyone",
                Role = "reader"
            };

            _driveService.Permissions.Create(permission, arquivoId).Execute();

            // Retorna o link para visualização
            string directLink = $"https://drive.google.com/uc?export=view&id={arquivoId}";
            return directLink;
        }
    }

    private string UploadNovoArquivo(string caminhoArquivo, string nomeArquivo, string pastaId)
    {
        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = nomeArquivo
        };

        if (!string.IsNullOrEmpty(pastaId))
            fileMetadata.Parents = new List<string> { pastaId };

        using (var stream = new FileStream(caminhoArquivo, FileMode.Open))
        {
            var request = _driveService.Files.Create(fileMetadata, stream, GetMimeType(caminhoArquivo));
            request.Fields = "id";
            request.Upload();

            var file = request.ResponseBody;
            string fileId = file.Id;

            var permission = new Google.Apis.Drive.v3.Data.Permission
            {
                Type = "anyone",
                Role = "reader"
            };

            _driveService.Permissions.Create(permission, fileId).Execute();

            var getRequest = _driveService.Files.Get(fileId);
            getRequest.Fields = "webViewLink, webContentLink";
            var fileInfo = getRequest.Execute();

            return fileInfo.WebContentLink ?? fileInfo.WebViewLink;
        }
    }

    public void DeletarArquivo(string cpf, string? nomePasta = null)
    {
        try
        {
            string pastaId = null;

            if (!string.IsNullOrEmpty(nomePasta))
                pastaId = ObterIdPastaPeloNome(nomePasta);
            
            string arquivoId = BuscarArquivoExistente(ManipularArquivoHelper.CalcularHash(cpf), pastaId);

            DeletarArquivoPorId(arquivoId);
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private void DeletarArquivoPorId(string fileId)
    {
        try
        {
            if (string.IsNullOrEmpty(fileId))
                throw new ArgumentException("ID do arquivo não pode ser nulo ou vazio");

            _driveService.Files.Delete(fileId).Execute();
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError(ex.Message);
        }
    }

    private string GetMimeType(string nomeDoArquivo)
    {
        string extension = Path.GetExtension(nomeDoArquivo).ToLower();
        
        switch (extension)
        {
            case ".jpg":
            case ".jpeg":
                return "image/jpeg";
            case ".png":
                return "image/png";
            case ".gif":
                return "image/gif";
            case ".ico":
                return "image/ico";
            default:
                return "application/octet-stream";
        }
    }
}
