using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.FluentAPI;

namespace portal_roadtrip.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        modelBuilder.ApplyConfiguration(new EventoPontoEmbarqueConfiguration());
        modelBuilder.ApplyConfiguration(new EventoFuncionarioConfiguration());
        modelBuilder.ApplyConfiguration(new ConexaoUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new EventoConfiguration());
        modelBuilder.ApplyConfiguration(new EventoClienteConfiguration());
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new CreditoConfiguration());
        modelBuilder.ApplyConfiguration(new EstornoConfiguration());
    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<PontoEmbarque> PontoEmbarque { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<EventoPontoEmbarque> EventoPontoEmbarque { get; set; }
    public DbSet<EventoFuncionario> EventoFuncionario { get; set; }
    public DbSet<Evento> Evento { get; set; }
    public DbSet<ConexaoUsuario> ConexaoUsuario { get; set; }
    public DbSet<Cargo> Cargo { get; set; }
    public DbSet<CategoriaEvento> CategoriaEvento { get; set; }
    public DbSet<EventoCliente> EventoCliente { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Credito> Credito { get; set; }
    public DbSet<Estorno> Estorno { get; set; }
}
