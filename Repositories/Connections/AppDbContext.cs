using ASFA.Models;
using Microsoft.EntityFrameworkCore;

namespace ASFA.Repositories.Connections;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // Configurar o rastreamento de alterações
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

        // Habilitar detecção de alterações automática
        ChangeTracker.AutoDetectChangesEnabled = true;
    }

    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<ComposicaoFamiliar> ComposicoesFamiliares { get; set; }
    public DbSet<PessoaIdosa> PessoasIdosas { get; set; }
    public DbSet<Dependente> Dependentes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Anexo> Anexos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações de tabelas
        ConfigurarTabelas(modelBuilder);

        // Configurações de relacionamentos
        ConfigurarRelacionamentos(modelBuilder);

        // Configurações de índices e restrições
        ConfigurarIndicesERestricoes(modelBuilder);
    }

    private void ConfigurarTabelas(ModelBuilder modelBuilder)
    {
        // Configuração TPT (Table Per Type)
        modelBuilder.Entity<Pessoa>().ToTable("Pessoas");
        modelBuilder.Entity<ComposicaoFamiliar>().ToTable("ComposicoesFamiliares");
        modelBuilder.Entity<PessoaIdosa>().ToTable("PessoasIdosas");
        modelBuilder.Entity<Dependente>().ToTable("Dependentes");
        modelBuilder.Entity<Endereco>().ToTable("Enderecos");
        modelBuilder.Entity<Anexo>().ToTable("Anexos");
    }

    private void ConfigurarRelacionamentos(ModelBuilder modelBuilder)
    {
        // Configuração do relacionamento um-para-um entre Pessoa e ComposicaoFamiliar
        modelBuilder.Entity<Pessoa>()
            .HasOne(p => p.ComposicaoFamiliar)
            .WithOne(c => c.Pessoa)
            .HasForeignKey<ComposicaoFamiliar>(c => c.PessoaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração do relacionamento um-para-um entre PessoaIdosa e Endereco
        modelBuilder.Entity<PessoaIdosa>()
            .HasOne(p => p.Endereco)
            .WithOne(e => e.PessoaIdosa)
            .HasForeignKey<Endereco>(e => e.PessoaIdosaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração do relacionamento um-para-muitos entre PessoaIdosa e Dependente
        modelBuilder.Entity<PessoaIdosa>()
            .HasMany(p => p.Dependentes)
            .WithOne(d => d.PessoaIdosa)
            .HasForeignKey(d => d.PessoaIdosaId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuração do relacionamento um-para-um entre PessoaIdosa e Anexo
        modelBuilder.Entity<PessoaIdosa>()
            .HasMany(p => p.Anexos)
            .WithOne(a => a.PessoaIdosa)
            .HasForeignKey(a => a.PessoaIdosaId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    private void ConfigurarIndicesERestricoes(ModelBuilder modelBuilder)
    {
        /*
        // Índices
        modelBuilder.Entity<Pessoa>()
            .HasIndex(p => p.Nome);

        modelBuilder.Entity<PessoaIdosa>()
            .HasIndex(p => p.Cpf)
            .IsUnique();

        // Restrições
        modelBuilder.Entity<PessoaIdosa>()
            .Property(p => p.Cpf)
            .HasMaxLength(11)
            .IsRequired();

        modelBuilder.Entity<Pessoa>()
            .Property(p => p.Nome)
            .HasMaxLength(100)
            .IsRequired();
        */
    }
}
