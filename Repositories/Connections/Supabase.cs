using ASFA.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Npgsql;
using RestSharp;
using System.Net;

namespace ASFA.Repositories.Connections;

public class Supabase
{
    private readonly string supabaseUrl;
    private readonly string supabaseAnonKey;
    private readonly string connectionString;
    private readonly RestClient client;

    public Supabase(IConfiguration configuration)
    {
        supabaseUrl = configuration["Supabase:Url"];
        supabaseAnonKey = configuration["Supabase:AnonKey"];
        connectionString = configuration.GetConnectionString("SupabaseConnection");
        client = new RestClient();
    }

    public NpgsqlConnection GetConnection()
    {
        var conn = new NpgsqlConnection(connectionString);
        conn.Open();
        return conn;
    }

    public string RegistrarUsuario(Login login)
    {
        var request = new RestRequest($"{supabaseUrl}/auth/v1/signup", Method.Post);
        request.AddHeader("apikey", supabaseAnonKey);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody(new { email = login.Email, password = login.Senha });

        var response = client.Execute(request);

        if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
        {
            return "Usuário registrado com sucesso";
        }

        try
        {
            var jsonResponse = JObject.Parse(response.Content);
            var mensagem = jsonResponse["msg"]?.ToString();
            return $"Erro: {mensagem ?? "Erro desconhecido"}";
        }
        catch (Exception)
        {
            return "Erro ao processar resposta do servidor.";
        }
    }

    public string LoginUsuario(Login login)
    {
        var request = new RestRequest($"{supabaseUrl}/auth/v1/token?grant_type=password", Method.Post);
        request.AddHeader("apikey", supabaseAnonKey);
        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody(new { email = login.Email, password = login.Senha });

        var response = client.Execute(request);

        var jsonResponse = JObject.Parse(response.Content);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            string accessToken = jsonResponse["access_token"]?.ToString();
            return accessToken;
        }
        else
        {
            string message = jsonResponse["msg"]?.ToString();
            return $"Erro: {message}";
        }
    }
}
