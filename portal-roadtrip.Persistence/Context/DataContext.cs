﻿using Microsoft.EntityFrameworkCore;
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
}