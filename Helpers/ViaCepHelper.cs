using ASFA.Models;
using System.Text.Json;

namespace ASFA.Helpers;

public class ViaCepHelper
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task<EnderecoViaCep> BuscarCepAsync(string cep)
    {
        try
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<EnderecoViaCep>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }
        catch (Exception ex)
        {
            MessageBoxHelper.ShowError($"Erro ao buscar CEP: {ex.Message}");
        }

        return null;
    }
}
