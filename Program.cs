using ASFA.Models.DTOs;
using ASFA.Repositories;
using ASFA.Repositories.Connections;
using ASFA.Repositories.Interfaces;
using ASFA.Services;
using ASFA.Services.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASFA;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Carregar configurações do appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Configurar injeção de dependências
        var services = new ServiceCollection();

        // Configuração do DbContext
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("SupabaseConnection")));

        // Registro de Repositórios, Serviços e Formulários
        AddRepositories(services);
        AddServices(services);
        services.AddSingleton<IConfiguration>(configuration);

        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));

        // Registro de formulários com dependências injetadas
        AddForms(services);

        // Criar o provedor de serviços
        var serviceProvider = services.BuildServiceProvider();

        //Application.Run(serviceProvider.GetRequiredService<FormMenu>());
        
        // Logar antes de acessar o sistema
        using (var formLogin = serviceProvider.GetRequiredService<FormLogin>())
        {
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(serviceProvider.GetRequiredService<FormMenu>());
            }
        }
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IPessoaIdosaRepository, PessoaIdosaRepository>();
        services.AddScoped<IEnderecoRepository, EnderecoRepository>();
        services.AddScoped<IDependenteRepository, DependenteRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<Supabase>();
        services.AddScoped<LoginService>();
        services.AddScoped<IPessoaIdosaService, PessoaIdosaService>();
        services.AddScoped<IEnderecoService, EnderecoService>();
        services.AddScoped<IDependenteService, DependenteService>();

        return services;
    }

    public static IServiceCollection AddForms(this IServiceCollection services)
    {
        services.AddTransient<FormLogin>();
        services.AddTransient<FormMenu>();
        services.AddTransient<FormCadastroPessoaIdosa>();
        services.AddTransient<FormCadastroDependente>();

        return services;
    }
}
